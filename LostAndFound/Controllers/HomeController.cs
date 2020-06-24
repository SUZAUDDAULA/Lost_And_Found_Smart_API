using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Models;
using LostAndFound.Services.AuthServices.Interfaces;
using LostAndFound.Sevices.AuthServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using LostAndFound.Helpers;
using LostAndFound.Models.Lang;
using Microsoft.AspNetCore.Hosting;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Services.MasterData.Interfaces;
using LostAndFound.Services.LostFoundServices.Interfaces;
using Microsoft.AspNetCore.Identity;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.LostFound;

namespace LostAndFound.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IPageAssignService pageAssignService;
        private readonly INavbarService navbarService;
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly ILostAndFoundService lostAndFoundService;
        private LAFDbContext _db;
        private readonly IModuleAssignService moduleAssignService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly LangGenerate<DashboardLn> _lang;
        private readonly LangGenerate<SearchLn> _sLang;
        private readonly string rootPath;
        private readonly MyPDF myPDF;
        public string FileName;

        public HomeController(IPageAssignService pageAssignService, INavbarService navbarService, ILostAndFoundType lostAndFoundType,
            LAFDbContext db, IModuleAssignService moduleAssignService, ILostAndFoundService lostAndFoundService,
            UserManager<ApplicationUser> userManager, IHostingEnvironment _hostingEnvironment, IConverter converter)
        {
            this.pageAssignService = pageAssignService;
            this.navbarService = navbarService;
            this.moduleAssignService = moduleAssignService;
            this.lostAndFoundType = lostAndFoundType;
            this.lostAndFoundService = lostAndFoundService;
            _userManager = userManager;
            _db = db;
            this._hostingEnvironment = _hostingEnvironment;
            _lang = new LangGenerate<DashboardLn>(_hostingEnvironment.ContentRootPath);
            _sLang = new LangGenerate<SearchLn>(_hostingEnvironment.ContentRootPath);
            myPDF = new MyPDF(_hostingEnvironment, converter);
            rootPath = _hostingEnvironment.ContentRootPath;
        }

        public async Task<IActionResult> Index()
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            DashboardViewModel model = new DashboardViewModel
            {
                gDInformation = await lostAndFoundService.GetAllGDInformation(),
                gDType = await lostAndFoundType.GetGDTypes(),
                dashboardLn = _lang.PerseLang("Dashboard/DashboardEN.json", "Dashboard/DashboardBN.json", Request.Cookies["lang"]),
            };

            return View(model);
            //SearchViewModel model = new SearchViewModel
            //{
            //    searchLn = _sLang.PerseLang("LostFound/SearchEN.json", "LostFound/SearchBN.json", Request.Cookies["lang"]),
            //};
            //return View(model);
        }
        [Route("api/Home/GetGDInformationByFiltering/{statusId}/{id}")]
        [HttpGet]
        public async Task<JsonResult> GetGDInformationByFiltering(int statusId,int id)
        {
            IEnumerable<GDInformation> gdInfo = new List<GDInformation>();
            //if (statusId == 0 && id==0)
            //{
            //    gdInfo = await lostAndFoundService.GetAllGDInformation();
            //}
            //else if(statusId == 0 && id == 0)
            //{
                gdInfo = await lostAndFoundService.GetAllGDInformationByGDType(statusId,id);
            //}
            
            return Json(gdInfo);
        }

        [Route("api/Home/GetGDInformationByStatus/{statusId}")]
        [HttpGet]
        public async Task<JsonResult> GetGDInformationByStatus(int statusId)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            IEnumerable<GDInformation> gdInfo = new List<GDInformation>();
            //if (statusId == 0 && id==0)
            //{
            //    gdInfo = await lostAndFoundService.GetAllGDInformation();
            //}
            //else if(statusId == 0 && id == 0)
            //{
            gdInfo = await lostAndFoundService.GetAllGDInformationByStatus(user.Id, statusId);
            //}

            return Json(gdInfo);
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            DashboardViewModel model = new DashboardViewModel
            {
                gDInformation = await lostAndFoundService.GetAllGDInformationByUser(user.Id),
                gDType=await lostAndFoundType.GetGDTypes(),
                dashboardLn = _lang.PerseLang("Dashboard/DashboardEN.json", "Dashboard/DashboardBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Search()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Report(int id)
        {
            string scheme = Request.Scheme;
            var host = Request.Host;
            string url = "";
            string fileName;
            url = scheme + "://" + host + "/Home/ApplicationReport";


            string status = myPDF.GeneratePDF(out fileName, url);

            FileName = fileName;
            if (status != "done")
            {
                return Content("<h1>" + status + "</h1>");
            }

            var stream = new FileStream(rootPath + "/wwwroot/pdf/" + fileName, FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");

        }
        [AllowAnonymous]
        public IActionResult ApplicationReport()
        {

            ReportViewModel model = new ReportViewModel();

            return PartialView(model);
        }

        public async Task<IActionResult> AssignPage()
        {
            string userName = HttpContext.User.Identity.Name;
            var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
            //List<string> roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();
            //List<int?> lstmodule = _db.UserAccessPages.Where(x => roleids.Contains(x.applicationRoleId)).Select(x => x.navbarId).ToList();

            //List<int> lstparentId = _db.Navbars.Where(x => lstmodule.Contains(x.Id)).Select(x => x.parentID).ToList();
            //List<int> lstparentIdF = _db.Navbars.Where(x => lstparentId.Contains(x.Id)).Select(x => x.parentID).ToList();

            var navdata = await pageAssignService.GetNavbars(userName);
            //var adminrole = _db.UserRoles.Where(x => x.UserId == userId && x.RoleId == "1052c2d9-d87f-4004-873c-1db3ed353e4f").ToList();
            //if (adminrole.Count() == 0)
            //{
            //    navdata = navdata.Where(x => lstmodule.Contains(x.Id) || lstparentId.Contains(x.Id) || lstparentIdF.Contains(x.Id));
            //}
            //List<int?> modid = navdata.Select(x => x.moduleId).ToList();
            var modules = await moduleAssignService.GetLAFModules();
            //if (adminrole.Count() == 0)
            //{
            //    modules = modules.Where(x => modid.Contains(x.Id));
            //}
            NavbarViewModel model = new NavbarViewModel
            {
                navbars = navdata,//await pageAssignService.GetNavbars(userName),
                ERPModules = modules//await pageAssignService.GetERPModules()
            };

            ViewBag.UserTypeID = 1;

            return PartialView("_Navbar", model);
        }

        public async Task<IActionResult> GridMenuPage(int moduleId, int perentId)
        {
            string userName = HttpContext.User.Identity.Name;
            var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
            
            List<string> roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();
            List<int?> lstmodule = _db.UserAccessPages.Where(x => roleids.Contains(x.applicationRoleId)).Select(x => x.navbarId).ToList();

            List<int> lstparentId = _db.Navbars.Where(x => lstmodule.Contains(x.Id)).Select(x => x.parentID).ToList();

            List<Navbar> lstMenu = _db.Navbars.Where(x => x.moduleId == moduleId && x.parentID == perentId && x.status == true).OrderBy(x => x.displayOrder).ToList();
            List<Navbar> lstChieldMenu = new List<Navbar>();
            
            var navdata = await pageAssignService.GetNavbars(userName);
            var adminrole = _db.UserRoles.Where(x => x.UserId == userId && x.RoleId == "c64a600e-a63a-49d1-b5f7-38f278832d3a").ToList();
            if (adminrole.Count() == 0)
            {
                lstChieldMenu = navdata.Where(x => lstmodule.Contains(x.Id)).ToList();
                lstMenu = lstMenu.Where(x => lstparentId.Contains(x.Id)).ToList();
            }
            else
            {
                lstChieldMenu = navdata.ToList();
            }
            lstChieldMenu = navdata.ToList();
            List<int?> modid = navdata.Select(x => x.moduleId).ToList();
            var modules = await moduleAssignService.GetLAFModules();
            //if (adminrole.Count() == 0)
            //{
            //    modules = modules.Where(x => modid.Contains(x.Id));
            //}

            var model = new NavbarViewModel
            {
                navbars = lstChieldMenu,
                navbarsbyparent = lstMenu,
                ERPModules = modules
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
