using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.Auth.Models;
using LostAndFound.Areas.Auth.Models.Lang;
using LostAndFound.Helpers;
using LostAndFound.Models;
using LostAndFound.Services.LostFoundServices.Interfaces;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Controllers
{
    public class PublicUserController : Controller
    {
        private readonly LangGenerate<RegisterLn> _langRegister;
        private readonly ILostAndFoundType lostAndFoundType;

        public PublicUserController(IHostingEnvironment hostingEnvironment, ILostAndFoundType lostAndFoundType)
        {
            _langRegister = new LangGenerate<RegisterLn>(hostingEnvironment.ContentRootPath);
            this.lostAndFoundType = lostAndFoundType;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PublicRegister()
        {
            var model = new RegisterViewModel
            {
                rLang = _langRegister.PerseLang("Auth/RegisterEN.json", "Auth/RegisterBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> RegisterStepOne(int id)
        {
            if (id == 1)
            {
                ViewBag.msg = "citizen";
            }
            else if(id == 2)
            {
                ViewBag.msg = "Foreigner";
            }
            else
            {
                return RedirectToAction("PublicRegister");
            }

            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                NationalIdentityTypes = await lostAndFoundType.GetNationalIdentityTypes()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterStepTwo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterStepTwo(RegisterViewModel model)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(model.FullName)) &&
                !string.IsNullOrEmpty(Convert.ToString(model.PhoneNumber)) &&
                !string.IsNullOrEmpty(Convert.ToString(model.Citizenship)))
            {
                return View(model);
            }
            else
            {
                int routeId = 0;
                if (model.Citizenship == "citizen")
                {
                    routeId = 1;
                }
                else if (model.Citizenship == "Foreigner")
                {
                    routeId = 2;
                }

                return RedirectToAction("RegisterStepOne", routeId);
            }
           
        }
    }
}