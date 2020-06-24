using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.MasterData.Models;
using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Helpers;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.MasterData.Controllers
{
    [Authorize]
    [Area("MasterData")]
    public class VehicleInformationController : Controller
    {
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly LangGenerate<VehicleInformationLn> _lang;

        public VehicleInformationController(IHostingEnvironment _hostingEnvironment, ILostAndFoundType lostAndFoundType)
        {
            this.lostAndFoundType = lostAndFoundType;
            this._hostingEnvironment = _hostingEnvironment;
            _lang = new LangGenerate<VehicleInformationLn>(_hostingEnvironment.ContentRootPath);
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            VehicleInformationViewModel model = new VehicleInformationViewModel
            {
                vehicleTypes=await lostAndFoundType.GetVehicleTypes(),
                fLang = _lang.PerseLang("MasterData/VehicaleInfoEN.json", "MasterData/VehicaleInfoBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] VehicleInformationViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/VehicleType", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            VehicleType vehicleType = new VehicleType
            {
                Id=(int)model.vehicleTypeId,
                vehicleTypeName = model.vehicleTypeName,
                vehicleTypeNameBn=model.vehicleTypeNameBn,
                imagePath= attachPath
            };
            await lostAndFoundType.SaveVehicleType(vehicleType);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteVehicle(int id)
        {
            var result= await lostAndFoundType.DeleteVehicleTypeById(id);
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> VehicleModel()
        {
            VehicleInformationViewModel model = new VehicleInformationViewModel
            {
                vehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                vehicleModels = await lostAndFoundType.GetVehicleModel(),
                fLang = _lang.PerseLang("MasterData/VehicaleInfoEN.json", "MasterData/VehicaleInfoBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> VehicleModel([FromForm] VehicleInformationViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/VehicleType", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            VehicleModel vehicleModel = new VehicleModel
            {
                Id = (int)model.modelId,
                vehicleTypeId=model.vehicleTypeId,
                modelName = model.modelName,
                imagePath=attachPath

            };
            await lostAndFoundType.SaveVehicleModel(vehicleModel);
            return RedirectToAction(nameof(VehicleModel));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteVehicleModel(int id)
        {
            var result = await lostAndFoundType.DeleteVehicleModelById(id);
            return Json(result);
        }

        [HttpGet]
        [Route("api/VehicleInformation/GetVehicleModelByVehicleId/{id}")]
        public async Task<JsonResult> GetVehicleModelByVehicleId(int id)
        {
            var result = await lostAndFoundType.GetVehicleModelByVehicleId(id);
            return Json(result);
        }

        #region Matropoliton Area

        [HttpGet]
        public async Task<IActionResult> MetropolitanArea()
        {
            MetropolitanAreaViewModel model = new MetropolitanAreaViewModel
            {
                metropolitanAreas=await lostAndFoundType.GetMetropolitanArea()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MetropolitanArea(MetropolitanAreaViewModel model)
        {
            string userName = User.Identity.Name;
            MetropolitanArea area = new MetropolitanArea
            {
                Id = (int)model.areaId,
                areaName = model.areaName,
                areaNameBn = model.areaNameBn,
                shortOrder = model.shortOrder
            };
            int id = await lostAndFoundType.SaveMetropolitanArea(area);
            return RedirectToAction(nameof(MetropolitanArea));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMetropolitanAreaById(int id)
        {
            var result = await lostAndFoundType.DeleteMetropolitanAreaById(id);
            return Json(result);
        }

        #endregion

        #region Registration Level

        [HttpGet]
        public async Task<IActionResult> RegistrationLevel()
        {
            RegistrationLevelViewModel model = new RegistrationLevelViewModel
            {
                registrationLevels = await lostAndFoundType.GetRegistrationLevel()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationLevel(RegistrationLevelViewModel model)
        {
            string userName = User.Identity.Name;
            RegistrationLevel level = new RegistrationLevel
            {
                Id = (int)model.levelId,
                levelName = model.levelName,
                levelNameBn = model.levelNameBn,
                shortOrder = model.shortOrder
            };
            int id = await lostAndFoundType.SaveRegistrationLevel(level);
            return RedirectToAction(nameof(RegistrationLevel));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteRegistrationLevelById(int id)
        {
            var result = await lostAndFoundType.DeleteRegistrationLevelById(id);
            return Json(result);
        }

        #endregion

    }
}