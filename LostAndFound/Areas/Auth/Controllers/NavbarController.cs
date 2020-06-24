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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class NavbarController : Controller
    {
        private readonly IModuleAssignService moduleAssignService;
        private readonly INavbarService navbarService;

        public NavbarController(IHostingEnvironment hostingEnvironment, INavbarService navbarService, IModuleAssignService moduleAssignService)
        {
            this.moduleAssignService = moduleAssignService;
            this.navbarService = navbarService;
        }

        // GET: Bank
        public async Task<IActionResult> Create()
        {
            var model = new NavbarViewModel
            {
                ERPModules = await moduleAssignService.GetLAFModules(),
                navbarsbyparent = await navbarService.GetNavbarItemByParent(),
                navbars = await navbarService.GetNavbarItem(),
            };
            return View(model);
        }

        // POST: Bank/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] NavbarViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ERPModules = await moduleAssignService.GetLAFModules();
                model.navbarsbyparent = await navbarService.GetNavbarItemByParent();
                model.navbars = await navbarService.GetNavbarItem();
                return View(model);
            }
            int? parentId = model.parentID;
            if (model.isParent == 2)
            {
                parentId = model.bandID;
            }

            Navbar data = new Navbar
            {
                Id = model.Id ?? 0,
                nameOption = model.nameOption,
                nameOptionBangla = model.nameOptionBangla,
                moduleId = model.moduleId,
                area = model.area,
                controller = model.controller,
                action = model.action,
                imageClass = model.imageClass,
                activeLi = model.activeLi,
                status = model.status,
                isParent = model.isParent,
                parentID = (int)parentId,
                displayOrder = model.displayOrder
            };

            await navbarService.SaveNavbarItem(data);

            return RedirectToAction(nameof(Create));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await navbarService.DeleteNavbarItemById(id);

            return RedirectToAction(nameof(Create));
        }

        #region API Section
        [Route("global/api/getNavbarItemByParentByModule/{moduleId}/{isParent}")]
        [HttpGet]
        public async Task<IActionResult> GetNavbarItemByParentByModule(int moduleId, int isParent)
        {
            return Json(await navbarService.GetNavbarItemByParentByModule(moduleId, isParent));
        }

        [Route("global/api/GetNavbarItemByParentIdByModule/{moduleId}/{isParent}")]
        [HttpGet]
        public async Task<IActionResult> GetNavbarItemByParentIdByModule(int moduleId, int isParent)
        {
            return Json(await navbarService.GetNavbarItemByParentIdByModule(moduleId, isParent));
        }

        [Route("global/api/GetNavbarParentIdById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetNavbarParentIdById(int id)
        {
            return Json(await navbarService.GetNavbarParentIdById(id));
        }

        #endregion

    }
}