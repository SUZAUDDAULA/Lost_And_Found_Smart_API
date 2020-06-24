using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using LostAndFound.Api.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity;
using LostAndFound.Services.AuthService;
using LostAndFound.Services.AuthServices;
using LostAndFound.Services.AuthServices.Interfaces;
using LostAndFound.Services.EmailService;
using LostAndFound.Services.EmailService.interfaces;
using LostAndFound.Services.jwt;
using LostAndFound.Services.jwt.Interfaces;
using LostAndFound.Services.LostFoundServices;
using LostAndFound.Services.LostFoundServices.Interfaces;
using LostAndFound.Services.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using LostAndFound.Services.MasterData.Interfaces.MDOtherItems;
using LostAndFound.Services.MasterData.MDOtherItems;
using LostAndFound.Services.SMSService;
using LostAndFound.Services.SMSService.Interface;
using LostAndFound.Sevices.AuthServices.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;

namespace LostAndFound
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            #region User Manage
            services.AddScoped<IPageAssignService, PageAssignService>();
            services.AddScoped<IUserInfoes, UserInfoesService>();
            services.AddScoped<INavbarService, NavbarService>();
            services.AddScoped<IModuleAssignService, ModuleAssignService>();
            #endregion

            #region Master Data
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<ILostAndFoundType, LostAndFoundTypeService>();
            services.AddTransient<IExtendedMasterDataService, ExtendedMasterDataService>();
            services.AddTransient<IElectronicService, ElectronicService>();
            services.AddTransient<IAddressCategoryService, AddressCategoryService>();
            services.AddTransient<ISMSConfigureService, SMSConfigureService>();
            #endregion

            #region LostAnd Found
            services.AddTransient<ILostAndFoundService, LostAndFoundService>();
            services.AddTransient<IOtherDocumentService, OtherDocumentService>();
            services.AddTransient<IAddressInformationService, AddressInformationService>();
            #endregion

            #region Email Service
            services.AddTransient<IEmailSenderService, EmailSenderService>();
            #endregion

            #region PDF DI
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            #endregion

            #region LAF Database Settings
            services.AddDbContext<LAFDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LAFConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<LAFDbContext>();
               //.AddDefaultTokenProviders(); 
            
            #endregion

            #region Auth JWT

            services.AddScoped<IFilterRoleService, FilterRoleService>();

            services.AddSingleton<IJwtFactoryService, JwtFactoryService>();
            var jwtAppsettingsOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtAppsettingsOptions["SecreatKey"]));

            services.Configure<JwtIssuerOptions>(Options =>
            {
                Options.Issuer = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Issuer)];
                Options.Audience = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Audience)];
                Options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
            #endregion

            #region Auth Related Settings
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.AddAuthentication().AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);

                options.LoginPath = "/Auth/Account/Login";
                options.AccessDeniedPath = "/Auth/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            #endregion

            #region Areas Config
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/areas/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/areas/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
               .AddJsonOptions(options => {
                   var resolver = options.SerializerSettings.ContractResolver;
                   if (resolver != null)
                       (resolver as DefaultContractResolver).NamingStrategy = null;
               });
            services.AddHttpContextAccessor();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromHours(24);
                options.Cookie.IsEssential = true;
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                     name: "areas",
                     template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=PublicUser}/{action=Index}/{id?}");
            });
        }
    }
}
