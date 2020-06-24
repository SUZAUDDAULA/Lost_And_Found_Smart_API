using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Services.AuthServices.Interfaces;
using LostAndFound.Sevices.AuthServices.Interfaces;
using LostAndFound.Areas.Auth.Models;
using LostAndFound.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LostAndFound.Helpers;
using LostAndFound.Areas.Auth.Models.Lang;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using LostAndFound.Services.EmailService.interfaces;
using System.Text.Encodings.Web;

namespace LostAndFound.Areas.Auth.Controllers
{
    [Authorize]
    [Area("Auth")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserInfoes userInfoes;
        //private readonly ILogger<RegisterViewModel> _logger;
        //private readonly IEmailSenderService emailSenderService;
        private LAFDbContext _db;
        private readonly IFilterRoleService filterRoleService;
        private readonly LangGenerate<RegisterLn> _langRegister;
        private readonly LangGenerate<OTPVarifiedLn> _langOTPCode;
        public AccountController(IHostingEnvironment hostingEnvironment,UserManager<ApplicationUser> userManager, LAFDbContext db, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, IUserInfoes userInfoes, IFilterRoleService filterRoleService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
            this.userInfoes = userInfoes;
            this.filterRoleService = filterRoleService;
            //this.emailSenderService = emailSenderService;
            _langRegister = new LangGenerate<RegisterLn>(hostingEnvironment.ContentRootPath);
            _langOTPCode = new LangGenerate<OTPVarifiedLn>(hostingEnvironment.ContentRootPath);
        }

        public IActionResult Index()
        {
            return View();
        }


        #region Register Login LogOut
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            //ViewBag.Data = await storeService.GetAllStore();
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LogInViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    ApplicationUser user = await _userManager.FindByNameAsync(model.Name);
                    var role = await _userManager.GetRolesAsync(user);
                    if(role.FirstOrDefault()=="Super Admin")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Dashboard", "Home");
                    }
                   
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    //ViewBag.Data = await storeService.GetAllStore();
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            string userName = HttpContext.User.Identity.Name;
            //ViewBag.UserList = userInfoes.GetUserTypeList();
            ViewData["ReturnUrl"] = returnUrl;
            var model = new RegisterViewModel
            {
                //userTypes = await userInfoes.GetUserTypeList(),
                //aspNetUsersViewModels = _db.AspNetUsersViewModels.FromSql("sp_GetAspNetUserslist"),
                //identityRoles = await userInfoes.GetAllRoles(),
                rLang = _langRegister.PerseLang("Auth/RegisterEN.json", "Auth/RegisterBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel model, string returnUrl = null)
        {
            
            ViewData["ReturnUrl"] = returnUrl;

            if (!string.IsNullOrEmpty(Convert.ToString(model.Citizenship)) &&
                !string.IsNullOrEmpty(Convert.ToString(model.FullName))&&
                !string.IsNullOrEmpty(Convert.ToString(model.PhoneNumber))&&
                !string.IsNullOrEmpty(Convert.ToString(model.Email))&&
                !string.IsNullOrEmpty(Convert.ToString(model.formFile)) &&
                !string.IsNullOrEmpty(Convert.ToString(model.Password)) &&
                !string.IsNullOrEmpty(Convert.ToString(model.ConfirmPassword)))
            {
                try
                {
                    string imagePath = string.Empty;
                    if (model.formFile != null)
                    {
                        string fileName;
                        string message = FileSave.SaveImage(out fileName, "Upload/GenarelUser", model.formFile);

                        if (message == "success")
                        {
                            imagePath = fileName;
                        }
                    }

                    int _min = 1000;
                    int _max = 9999;
                    Random _rdm = new Random();
                    int otpCode= _rdm.Next(_min, _max);

                    var user = new ApplicationUser
                    {
                        UserName = model.PhoneNumber,
                        PhoneNumber = model.PhoneNumber,
                        Email = model.Email,
                        userTypeId = 3,
                        Citizenship = model.Citizenship,
                        FullName = model.FullName,
                        NationalIdentityType = model.NationalIdentityType,
                        NationalIdentityNo = model.NationalIdentityNo,
                        AddressType = model.AddressType,
                        ImagePath = imagePath,
                        otpCode=otpCode.ToString(),
                        isVarified=0,
                        createdAt = DateTime.Now
                    };


                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                        

                        //_logger.LogInformation("User created a new account with password.");

                        //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        //var callbackUrl = Url.Page(
                        //    "/Account/OTPVarified",
                        //    pageHandler: null,
                        //    values: new { userId = user.Id, code = code },
                        //    protocol: Request.Scheme);

                        //await emailSenderService.SendEmail(model.Email, "Confirm your email",
                            //$"Your Verification Code is "+otpCode+" ,Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        await _userManager.AddToRoleAsync(user, "General User");
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("OTPVarified", "Account", new { Area = "Auth" });

                    //await _userManager.AddToRoleAsync(user, model.userRole);
                }
                else
                {
                    AddErrors(result);
                }



                //_db.Database.ExecuteSqlCommand("sp_UpdateAspNetUsers @p0,@p1,@p2,@p3", model.userid, model.UserTypeId, model.Name, model.Email);
                //await _userManager.RemovePasswordAsync(user);
                //await _userManager.AddPasswordAsync(user, model.Password);
                //return RedirectToAction("Register", "Account", new { Area = "Auth" });

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }

            model.rLang =
                _langRegister.PerseLang("Auth/RegisterEN.json", "Auth/RegisterBN.json", Request.Cookies["lang"]);

            return View(model);

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> OTPVarified()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            OTPCodeVarificationViewModel model = new OTPCodeVarificationViewModel
            {
                otpCode = user.otpCode,
                oLang = _langOTPCode.PerseLang("Auth/OTPVarifiedEN.json", "Auth/OTPVarifiedBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        //POST: api/Account/OTPVarified
        [HttpGet]
        public async Task<JsonResult> OTPVarifiedMatching(string otpCode)
        {

            try
            {
                var userName = User.Identity.Name;
                string returnResult = "success";

                var user = await _userManager.FindByNameAsync(userName);
                if (user.otpCode == otpCode)
                    returnResult = "success";
                else
                    returnResult = "error";

                return Json(returnResult);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Client Registration


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ClientRegister(string returnUrl = null)
        {

            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //_logger.LogInformation("User logged out.");
            var ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        #endregion

        #region Roles

        [HttpGet]
        public async Task<IActionResult> CreateRole()
        {
            RolesViewModel model = new RolesViewModel
            {
                identityRoles = await userInfoes.GetAllRoles()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RolesViewModel model)
        {
            var result = "error";

            int data = await userInfoes.SaveRole(model);

            if (data == 1)
            {
                result = "success";
            }

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole()
        {
            var model = new RegisterViewModel
            {
                userTypes = await userInfoes.GetUserTypeList(),
                aspNetUsersViewModels = _db.AspNetUsersViewModels.FromSql("sp_GetAspNetUserslist"),
                identityRoles = await userInfoes.GetAllRoles()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(RegisterViewModel model)
        {
            try
            {
                ApplicationUser user = await _userManager.FindByNameAsync(model.UserName);
                
                //for (int r = 0; r < model.removeRoles.Length; r++)
                //{
                //    await _userManager.RemoveFromRoleAsync(user, model.removeRoles[r]);
                //}

                for (int i = 0; i < model.assignRoles.Length; i++)
                {
                    await _userManager.AddToRoleAsync(user, model.assignRoles[i]);
                }

                return Json("success");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        // Filter Role By User

        [HttpPost]
        public async Task<IActionResult> FilterRoleByUser(string id)
        {

           IEnumerable<FileterRoleByUserViewModel> model = await filterRoleService.GetFilterRoleByUserId(id);

            return Json(model);
        }

        #endregion

        #region

        [HttpPost]
        public async Task<IActionResult> ChangePassword(RegisterViewModel model)
        {

            var result = "error";

            if(!string.IsNullOrEmpty(model.OldPassword) && !string.IsNullOrEmpty(model.Password))
            {
                var username = User.Identity.Name;

                var user = await _userManager.FindByNameAsync(username);

                await _userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);

                result = "success";
            }
            else
            {
                return Json(result);
            }

            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(RegisterViewModel model)
        {

            var result = "error";

            if(!string.IsNullOrEmpty(model.UserName) && !string.IsNullOrEmpty(model.Password) && !string.IsNullOrEmpty(model.ConfirmPassword))
            {
                var user  = await _userManager.FindByNameAsync(model.UserName);

                await _userManager.RemovePasswordAsync(user);

                if(user.PasswordHash == null)
                {
                   await _userManager.AddPasswordAsync(user, model.Password);
                }

                result = "success";
            }
            else
            {
                return Json(result);
            }

            return Json(result);
        }

        #endregion

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        #endregion
    }
}