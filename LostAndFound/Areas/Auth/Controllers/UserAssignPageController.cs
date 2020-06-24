using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Services.AuthServices.Interfaces;
using LostAndFound.Sevices.AuthServices.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LostAndFound.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class UserAssignPageController : Controller
    {
        private readonly IPageAssignService pageAssignService;
        private readonly IModuleAssignService moduleAssignService;
        private readonly IUserInfoes userInfoes;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private LAFDbContext _db;

        public UserAssignPageController(IPageAssignService pageAssignService, LAFDbContext db, IModuleAssignService moduleAssignService
            , IUserInfoes userInfoes, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.pageAssignService = pageAssignService;
            this.userInfoes = userInfoes;
            this.moduleAssignService = moduleAssignService;
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexModule()
        {
            return View();
        }
        public IActionResult ModuleAssign()
        {
            return View();
        }
        public IActionResult ModuleAssignERP()
        {
            return View();
        }

        //[Route("api/UserAssignPage/GetUserMenuAccess/{userRoleId}")]
        [HttpGet]
        public async Task<IActionResult> GetUserMenuAccess(string roleId)
        {
            try
            {
                var data = await pageAssignService.GetUserMenuAccessByUserType(roleId);
                return Json(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<JsonResult> GetUserModuleAccess(string userRoleId)
        {
            try
            {
                var data = await moduleAssignService.GetModuleAccessPagesactive(userRoleId);
                return Json(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<JsonResult> GetUserModuleAccessERP(string userRoleId)
        {
            try
            {
                string userName = HttpContext.User.Identity.Name;
                var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
                // var data = _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
                List<string> roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();
                var datamodule = await moduleAssignService.GetModuleAccessPages();
                List<int?> datamoduleId = datamodule.Where(x => roleids.Contains(x.applicationRoleId)).Select(x => x.inventoryModuleId).ToList();
                var data = await moduleAssignService.GetModuleAccessPagesactive(userRoleId);
                return Json(data.Where(x => datamoduleId.Contains(x.InventoryModuleId)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<JsonResult> GetUserMenuAccessModule(string userTypeId)
        {
            try
            {
                string userName = HttpContext.User.Identity.Name;
                var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
                // var data = _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
                string roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).FirstOrDefault();
                var data = await pageAssignService.GetUserMenuAccessByUserTypeModule(userTypeId, roleids);

                return Json(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> SaveUserMenuAccess(string UserTypeIds, int[] AllMenuIds)
        {
            await pageAssignService.DeleteUserAccesspageByUserTypeId(UserTypeIds);

            foreach (var app in AllMenuIds)
            {
                UserAccessPage UAP = new UserAccessPage();
                UAP.Id = 0;
                UAP.applicationRoleId = UserTypeIds;
                UAP.isAccess = 1;
                UAP.navbarId = Convert.ToInt32(app);

                await pageAssignService.SaveUserAccessPage(UAP);
                UAP = new UserAccessPage();

            }


            return Json(new { result = "1" });
        }
        [HttpPost]
        public async Task<JsonResult> SaveUserModuleAccess(string UserTypeIds, int[] AllMenuIds)
        {
            await moduleAssignService.DeleteModuleAccesspageByUserTypeId(UserTypeIds);

            foreach (var app in AllMenuIds)
            {
                ModuleAccessPage UAP = new ModuleAccessPage();
                UAP.Id = 0;
                UAP.applicationRoleId = UserTypeIds;

                UAP.inventoryModuleId = Convert.ToInt32(app);

                await moduleAssignService.SaveModuleAccessPage(UAP);
                UAP = new ModuleAccessPage();

            }


            return Json(new { result = "1" });
        }

        public async Task<IActionResult> GetUserType()
        {
            string userName = HttpContext.User.Identity.Name;
            string[] adminRoles = { "1052c2d9-d87f-4004-873c-1db3ed353e4f", "c64a600e-a63a-49d1-b5f7-38f278832d3a" };
            var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
            // var data = _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            List<string> roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();
            //var roles = await _roleManager.Roles.Where(x => !adminRoles.Contains(x.Id)).ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();
            var result = roles; //await userInfoes.GetUserTypeList();
            return Json(result);
        }
        public async Task<IActionResult> GetUserTypeERP()
        {
            string userName = HttpContext.User.Identity.Name;
            var userId = _db.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault();
            // var data = _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            List<string> roleids = _db.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();

            var roles = await _roleManager.Roles.Where(x => !roleids.Contains(x.Id) && x.Name != "Admin" && x.Name != "Super Admin").ToListAsync();
            var result = roles; //await userInfoes.GetUserTypeList();
            return Json(result);
        }
    }
}