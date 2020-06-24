using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.MasterData.Models;
using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using LostAndFound.Helpers;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.MasterData.Controllers
{
    [Area("MasterData")]
    public class ExtendedMasterDataController : Controller
    {
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly LangGenerate<ExtendedMasterDataLn> _lang;
        private readonly IExtendedMasterDataService _extendedMasterDataService;

        public ExtendedMasterDataController(
            IHostingEnvironment _hostingEnvironment,
            ILostAndFoundType lostAndFoundType,
            IExtendedMasterDataService _extendedMasterDataService)
        {
            this.lostAndFoundType = lostAndFoundType;
            this._hostingEnvironment = _hostingEnvironment;
            this._extendedMasterDataService = _extendedMasterDataService;
            _lang = new LangGenerate<ExtendedMasterDataLn>(_hostingEnvironment.ContentRootPath);
        }

        #region AddressSource

        [HttpGet]
        public async Task<IActionResult> AddressSourceType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                AddressSourceType = await _extendedMasterDataService.GetAllAddressSourceType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddressSourceType([FromForm] ExtendedMasterDataViewModel model)
        {
            AddressSourceType type = new AddressSourceType
            {
                Id = (int)model.id,
                sourceName = model.nameEnglish,
                sourceNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveAddressSourceType(type);
            return RedirectToAction(nameof(AddressSourceType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteAddressSourceType(int id)
        {
            var result = await _extendedMasterDataService.DeleteAddressSourceTypeById(id);
            return Json(result);
        }

        #endregion

        #region BeardType

        [HttpGet]
        public async Task<IActionResult> BeardType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                BeardTypes = await _extendedMasterDataService.GetAllBeardType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BeardType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            BeardType type = new BeardType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveBeardType(type);
            return RedirectToAction(nameof(BeardType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteBeardType(int id)
        {
            var result = await _extendedMasterDataService.DeleteBeardTypeById(id);
            return Json(result);
        }

        #endregion

        #region BodyChinType

        [HttpGet]
        public async Task<IActionResult> BodyChinType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                BodyChinTypes = await _extendedMasterDataService.GetAllBodyChinType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BodyChinType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            BodyChinType type = new BodyChinType
            {
                Id = (int)model.id,
                chinTypeName = model.nameEnglish,
                chinTypeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveBodyChinType(type);
            return RedirectToAction(nameof(BodyChinType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteBodyChinType(int id)
        {
            var result = await _extendedMasterDataService.DeleteBodyChinTypeById(id);
            return Json(result);
        }

        #endregion

        #region BodyColor

        [HttpGet]
        public async Task<IActionResult> BodyColor()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                BodyColors = await _extendedMasterDataService.GetAllBodyColor(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BodyColor([FromForm] ExtendedMasterDataViewModel model)
        {

            BodyColor type = new BodyColor
            {
                Id = (int)model.id,
                colorName = model.nameEnglish,
                colorNameBn = model.nameBangla,
                colorCode = model.colorCode

            };
            await _extendedMasterDataService.SaveBodyColor(type);
            return RedirectToAction(nameof(BodyColor));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteBodyColor(int id)
        {
            var result = await _extendedMasterDataService.DeleteBodyColorById(id);
            return Json(result);
        }

        #endregion

        #region BodyStructure

        [HttpGet]
        public async Task<IActionResult> BodyStructure()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                BodyStructures = await _extendedMasterDataService.GetAllBodyStructure(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BodyStructure([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            BodyStructure type = new BodyStructure
            {
                Id = (int)model.id,
                structureName = model.nameEnglish,
                structureNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveBodyStructure(type);
            return RedirectToAction(nameof(BodyStructure));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteBodyStructure(int id)
        {
            var result = await _extendedMasterDataService.DeleteBodyStructureById(id);
            return Json(result);
        }

        #endregion

        #region CareType

        [HttpGet]
        public async Task<IActionResult> CareType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                CareTypes = await _extendedMasterDataService.GetAllCareType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CareType([FromForm] ExtendedMasterDataViewModel model)
        {
            CareType type = new CareType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveCareType(type);
            return RedirectToAction(nameof(CareType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteCareType(int id)
        {
            var result = await _extendedMasterDataService.DeleteCareTypeById(id);
            return Json(result);
        }

        #endregion

        #region Complextion

        [HttpGet]
        public async Task<IActionResult> Complextion()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                Complextions = await _extendedMasterDataService.GetAllComplextion(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Complextion([FromForm] ExtendedMasterDataViewModel model)
        {

            Complextion type = new Complextion
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                colorCode = model.colorCode

            };
            await _extendedMasterDataService.SaveComplextion(type);
            return RedirectToAction(nameof(Complextion));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteComplextion(int id)
        {
            var result = await _extendedMasterDataService.DeleteComplextionById(id);
            return Json(result);
        }

        #endregion

        #region DeadbodyCondition

        [HttpGet]
        public async Task<IActionResult> DeadbodyCondition()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                DeadbodyConditions = await _extendedMasterDataService.GetAllDeadbodyCondition(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeadbodyCondition([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DeadbodyCondition type = new DeadbodyCondition
            {
                Id = (int)model.id,
                conditionName = model.nameEnglish,
                conditionNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveDeadbodyCondition(type);
            return RedirectToAction(nameof(DeadbodyCondition));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDeadbodyCondition(int id)
        {
            var result = await _extendedMasterDataService.DeleteDeadbodyConditionById(id);
            return Json(result);
        }

        #endregion

        #region DeathType

        [HttpGet]
        public async Task<IActionResult> DeathType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                DeathTypes = await _extendedMasterDataService.GetAllDeathType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeathType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DeathType type = new DeathType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveDeathType(type);
            return RedirectToAction(nameof(DeathType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDeathType(int id)
        {
            var result = await _extendedMasterDataService.DeleteDeathTypeById(id);
            return Json(result);
        }

        #endregion

        #region Age Period

        [HttpGet]
        public async Task<IActionResult> AgePeriod()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                AgePeriods = await _extendedMasterDataService.GetAllAgePeriod(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AgePeriod([FromForm] ExtendedMasterDataViewModel model)
        {
            
            AgePeriod agePeriod = new AgePeriod
            {
                Id = (int)model.id,
                periodName = model.nameEnglish,
                periodNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveAgePeriod(agePeriod);
            return RedirectToAction(nameof(AgePeriod));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteAgePeriodById(int id)
        {
            var result = await _extendedMasterDataService.DeleteAgePeriodById(id);
            return Json(result);
        }

        #endregion

        #region EarType

        [HttpGet]
        public async Task<IActionResult> EarType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                EarTypes = await _extendedMasterDataService.GetAllEarType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EarType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            EarType type = new EarType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveEarType(type);
            return RedirectToAction(nameof(EarType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteEarType(int id)
        {
            var result = await _extendedMasterDataService.DeleteEarTypeById(id);
            return Json(result);
        }

        #endregion

        #region EyeType

        [HttpGet]
        public async Task<IActionResult> EyeType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                EyeTypes = await _extendedMasterDataService.GetAllEyeType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EyeType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            EyeType type = new EyeType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveEyeType(type);
            return RedirectToAction(nameof(EyeType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteEyeType(int id)
        {
            var result = await _extendedMasterDataService.DeleteEyeTypeById(id);
            return Json(result);
        }

        #endregion

        #region EyeType

        [HttpGet]
        public async Task<IActionResult> FaceShapeType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                FaceShapeTypes = await _extendedMasterDataService.GetAllFaceShapeType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> FaceShapeType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            FaceShapeType type = new FaceShapeType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveFaceShapeType(type);
            return RedirectToAction(nameof(FaceShapeType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteFaceShapeType(int id)
        {
            var result = await _extendedMasterDataService.DeleteFaceShapeTypeById(id);
            return Json(result);
        }

        #endregion

        #region ForeHeadType

        [HttpGet]
        public async Task<IActionResult> ForeHeadType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                ForeHeadTypes = await _extendedMasterDataService.GetAllForeHeadType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ForeHeadType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            ForeHeadType type = new ForeHeadType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveForeHeadType(type);
            return RedirectToAction(nameof(ForeHeadType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteForeHeadType(int id)
        {
            var result = await _extendedMasterDataService.DeleteForeHeadTypeById(id);
            return Json(result);
        }

        #endregion

        #region HairType

        [HttpGet]
        public async Task<IActionResult> HairType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                HairTypes = await _extendedMasterDataService.GetAllHairType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> HairType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            HairType type = new HairType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveHairType(type);
            return RedirectToAction(nameof(HairType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteHairType(int id)
        {
            var result = await _extendedMasterDataService.DeleteHairTypeById(id);
            return Json(result);
        }

        #endregion#region HairType

        #region HeadType
        [HttpGet]
        public async Task<IActionResult> HeadType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                HeadTypes = await _extendedMasterDataService.GetAllHeadType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> HeadType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            HeadType type = new HeadType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveHeadType(type);
            return RedirectToAction(nameof(HeadType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteHeadType(int id)
        {
            var result = await _extendedMasterDataService.DeleteHeadTypeById(id);
            return Json(result);
        }

        #endregion

        #region InTheBody
        [HttpGet]
        public async Task<IActionResult> InTheBody()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                InTheBodys = await _extendedMasterDataService.GetAllInTheBody(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InTheBody([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            InTheBody type = new InTheBody
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveInTheBody(type);
            return RedirectToAction(nameof(InTheBody));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteInTheBody(int id)
        {
            var result = await _extendedMasterDataService.DeleteInTheBodyById(id);
            return Json(result);
        }

        #endregion

        #region  InTheHead
        [HttpGet]
        public async Task<IActionResult> InTheHead()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                InTheHeads = await _extendedMasterDataService.GetAllInTheHead(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InTheHead([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            InTheHead type = new InTheHead
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveInTheHead(type);
            return RedirectToAction(nameof(InTheHead));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteInTheHead(int id)
        {
            var result = await _extendedMasterDataService.DeleteInTheHeadById(id);
            return Json(result);
        }

        #endregion

        #region  InTheLegs
        [HttpGet]
        public async Task<IActionResult> InTheLegs()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                InTheLegs = await _extendedMasterDataService.GetAllInTheLegs(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InTheLegs([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            InTheLegs type = new InTheLegs
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveInTheLegs(type);
            return RedirectToAction(nameof(InTheLegs));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteInTheLegs(int id)
        {
            var result = await _extendedMasterDataService.DeleteInTheLegsById(id);
            return Json(result);
        }

        #endregion

        #region  InTheThroat
        [HttpGet]
        public async Task<IActionResult> InTheThroat()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                InTheThroats = await _extendedMasterDataService.GetAllInTheThroat(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InTheThroat([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            InTheThroat type = new InTheThroat
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveInTheThroat(type);
            return RedirectToAction(nameof(InTheThroat));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteInTheThroat(int id)
        {
            var result = await _extendedMasterDataService.DeleteInTheThroatById(id);
            return Json(result);
        }

        #endregion

        #region  InTheWaist
        [HttpGet]
        public async Task<IActionResult> InTheWaist()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                InTheWaists = await _extendedMasterDataService.GetAllInTheWaist(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> InTheWaist([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            InTheWaist type = new InTheWaist
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveInTheWaist(type);
            return RedirectToAction(nameof(InTheWaist));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteInTheWaist(int id)
        {
            var result = await _extendedMasterDataService.DeleteInTheWaistById(id);
            return Json(result);
        }

        #endregion

        #region MaritalStatus

        [HttpGet]
        public async Task<IActionResult> MaritalStatus()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                MaritalStatus = await _extendedMasterDataService.GetAllMaritalStatus(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MaritalStatus([FromForm] ExtendedMasterDataViewModel model)
        {
            MaritalStatus type = new MaritalStatus
            {
                Id = (int)model.id,
                name = model.nameEnglish,
                nameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveMaritalStatus(type);
            return RedirectToAction(nameof(MaritalStatus));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMaritalStatus(int id)
        {
            var result = await _extendedMasterDataService.DeleteMaritalStatusById(id);
            return Json(result);
        }

        #endregion

        #region MeasurementType

        [HttpGet]
        public async Task<IActionResult> MeasurementType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                MeasurementTypes = await _extendedMasterDataService.GetAllMeasurementType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MeasurementType([FromForm] ExtendedMasterDataViewModel model)
        {
            MeasurementType type = new MeasurementType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveMeasurementType(type);
            return RedirectToAction(nameof(MeasurementType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMeasurementType(int id)
        {
            var result = await _extendedMasterDataService.DeleteMeasurementTypeById(id);
            return Json(result);
        }

        #endregion

        #region  MeterialCondition
        [HttpGet]
        public async Task<IActionResult> MeterialCondition()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                MeterialConditions = await _extendedMasterDataService.GetAllMeterialCondition(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MeterialCondition([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            MeterialCondition type = new MeterialCondition
            {
                Id = (int)model.id,
                conditionName = model.nameEnglish,
                conditionNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveMeterialCondition(type);
            return RedirectToAction(nameof(MeterialCondition));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMeterialCondition(int id)
        {
            var result = await _extendedMasterDataService.DeleteMeterialConditionById(id);
            return Json(result);
        }

        #endregion

        #region  MoustacheType
        [HttpGet]
        public async Task<IActionResult> MoustacheType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                MoustacheTypes = await _extendedMasterDataService.GetAllMoustacheType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MoustacheType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            MoustacheType type = new MoustacheType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveMoustacheType(type);
            return RedirectToAction(nameof(MoustacheType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMoustacheType(int id)
        {
            var result = await _extendedMasterDataService.DeleteMoustacheTypeById(id);
            return Json(result);
        }

        #endregion

        #region  MouthType
        [HttpGet]
        public async Task<IActionResult> MouthType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                MouthTypes = await _extendedMasterDataService.GetAllMouthType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MouthType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            MouthType type = new MouthType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveMouthType(type);
            return RedirectToAction(nameof(MouthType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMouthType(int id)
        {
            var result = await _extendedMasterDataService.DeleteMouthTypeById(id);
            return Json(result);
        }

        #endregion

        #region  NeckType
        [HttpGet]
        public async Task<IActionResult> NeckType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                NeckTypes = await _extendedMasterDataService.GetAllNeckType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NeckType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            NeckType type = new NeckType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveNeckType(type);
            return RedirectToAction(nameof(NeckType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteNeckType(int id)
        {
            var result = await _extendedMasterDataService.DeleteNeckTypeById(id);
            return Json(result);
        }

        #endregion

        #region  Nose Type
        [HttpGet]
        public async Task<IActionResult> NoseType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                NoseTypes = await _extendedMasterDataService.GetAllNoseType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NoseType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            NoseType type = new NoseType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveNoseType(type);
            return RedirectToAction(nameof(NoseType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteNoseType(int id)
        {
            var result = await _extendedMasterDataService.DeleteNoseTypeById(id);
            return Json(result);
        }

        #endregion

        #region  NumberType
        [HttpGet]
        public async Task<IActionResult> NumberType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                NumberTypes = await _extendedMasterDataService.GetAllNumberType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NumberType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            NumberType type = new NumberType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveNumberType(type);
            return RedirectToAction(nameof(NumberType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteNumberType(int id)
        {
            var result = await _extendedMasterDataService.DeleteNumberTypeById(id);
            return Json(result);
        }

        #endregion

        #region PurposeOfVisite

        [HttpGet]
        public async Task<IActionResult> PurposeOfVisite()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                PurposeOfVisites = await _extendedMasterDataService.GetAllPurposeOfVisite(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PurposeOfVisite([FromForm] ExtendedMasterDataViewModel model)
        {
            PurposeOfVisite type = new PurposeOfVisite
            {
                Id = (int)model.id,
                purposeName = model.nameEnglish,
                purposeNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SavePurposeOfVisite(type);
            return RedirectToAction(nameof(PurposeOfVisite));
        }

        [HttpPost]
        public async Task<JsonResult> DeletePurposeOfVisite(int id)
        {
            var result = await _extendedMasterDataService.DeletePurposeOfVisiteById(id);
            return Json(result);
        }

        #endregion

        #region  Religion
        [HttpGet]
        public async Task<IActionResult> Religion()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                Religions = await _extendedMasterDataService.GetAllReligion(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Religion([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            Religion type = new Religion
            {
                Id = (int)model.id,
                religionName = model.nameEnglish,
                religionNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveReligion(type);
            return RedirectToAction(nameof(Religion));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteReligion(int id)
        {
            var result = await _extendedMasterDataService.DeleteReligionById(id);
            return Json(result);
        }

        #endregion

        #region ReligionCust

        [HttpGet]
        public async Task<IActionResult> ReligionCust()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                Religions = await _extendedMasterDataService.GetAllReligion(),
                ReligionCusts = await _extendedMasterDataService.GetAllReligionCust(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ReligionCust([FromForm] ExtendedMasterDataViewModel model)
        {
            ReligionCust type = new ReligionCust
            {
                Id = (int)model.id,
                religionId = model.religionId,
                custName = model.nameEnglish,
                custNameBn = model.nameBangla,

            };
            await _extendedMasterDataService.SaveReligionCust(type);
            return RedirectToAction(nameof(ReligionCust));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteReligionCust(int id)
        {
            var result = await _extendedMasterDataService.DeleteReligionCustById(id);
            return Json(result);
        }

        #endregion

        #region  SpecialBodyCondition
        [HttpGet]
        public async Task<IActionResult> SpecialBodyCondition()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                SpecialBodyConditions = await _extendedMasterDataService.GetAllSpecialBodyCondition(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SpecialBodyCondition([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            SpecialBodyCondition type = new SpecialBodyCondition
            {
                Id = (int)model.id,
                conditionName = model.nameEnglish,
                conditionNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveSpecialBodyCondition(type);
            return RedirectToAction(nameof(SpecialBodyCondition));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteSpecialBodyCondition(int id)
        {
            var result = await _extendedMasterDataService.DeleteSpecialBodyConditionById(id);
            return Json(result);
        }

        #endregion


        #region  TeethType
        [HttpGet]
        public async Task<IActionResult> TeethType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                TeethTypes = await _extendedMasterDataService.GetAllTeethType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> TeethType([FromForm] ExtendedMasterDataViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ExtendedMasterData", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            TeethType type = new TeethType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla,
                imagePath = attachPath

            };
            await _extendedMasterDataService.SaveTeethType(type);
            return RedirectToAction(nameof(TeethType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteTeethType(int id)
        {
            var result = await _extendedMasterDataService.DeleteTeethTypeById(id);
            return Json(result);
        }

        #endregion

        #region  Relation Type
        [HttpGet]
        public async Task<IActionResult> RelationType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                relationTypes = await _extendedMasterDataService.GetAllRelationType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RelationType([FromForm] ExtendedMasterDataViewModel model)
        {
            RelationType type = new RelationType
            {
                Id = (int)model.id,
                relationName = model.nameEnglish,
                relationNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveRelationType(type);
            return RedirectToAction(nameof(RelationType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteRelationTypeById(int id)
        {
            var result = await _extendedMasterDataService.DeleteRelationTypeById(id);
            return Json(result);
        }

        #endregion

        #region  Habits
        [HttpGet]
        public async Task<IActionResult> HabitInfo()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                habits = await _extendedMasterDataService.GetAllHabit(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> HabitInfo([FromForm] ExtendedMasterDataViewModel model)
        {
            Habit habit = new Habit
            {
                Id = (int)model.id,
                habitName = model.nameEnglish,
                habitNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveHabit(habit);
            return RedirectToAction(nameof(HabitInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteHabitById(int id)
        {
            var result = await _extendedMasterDataService.DeleteHabitById(id);
            return Json(result);
        }

        #endregion

        #region  Speech
        [HttpGet]
        public async Task<IActionResult> SpeechInfo()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                speeches = await _extendedMasterDataService.GetAllSpeech(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SpeechInfo([FromForm] ExtendedMasterDataViewModel model)
        {
            Speech speech = new Speech
            {
                Id = (int)model.id,
                speechName = model.nameEnglish,
                speechNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveSpeech(speech);
            return RedirectToAction(nameof(SpeechInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteSpeechById(int id)
        {
            var result = await _extendedMasterDataService.DeleteSpeechById(id);
            return Json(result);
        }

        #endregion

        #region  Special BirthMark Type
        [HttpGet]
        public async Task<IActionResult> SpecialBirthMarkType()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                specialBirthMarkTypes = await _extendedMasterDataService.GetAllSpecialBirthMarkType(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SpecialBirthMarkType([FromForm] ExtendedMasterDataViewModel model)
        {
            SpecialBirthMarkType markType = new SpecialBirthMarkType
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveSpecialBirthMarkType(markType);
            return RedirectToAction(nameof(SpecialBirthMarkType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteSpecialBirthMarkTypeById(int id)
        {
            var result = await _extendedMasterDataService.DeleteSpecialBirthMarkTypeById(id);
            return Json(result);
        }

        #endregion

        #region  Special BirthMark Body Part
        [HttpGet]
        public async Task<IActionResult> SpecialBirthMarkBodyPart()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                specialBirthMarkBodyParts = await _extendedMasterDataService.GetAllSpecialBirthMarkBodyPart(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SpecialBirthMarkBodyPart([FromForm] ExtendedMasterDataViewModel model)
        {
            SpecialBirthMarkBodyPart bodyPart = new SpecialBirthMarkBodyPart
            {
                Id = (int)model.id,
                bodyName = model.nameEnglish,
                bodyNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveSpecialBirthMarkBodyPart(bodyPart);
            return RedirectToAction(nameof(SpecialBirthMarkBodyPart));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteSpecialBirthMarkBodyPartById(int id)
        {
            var result = await _extendedMasterDataService.DeleteSpecialBirthMarkBodyPartById(id);
            return Json(result);
        }

        #endregion

        #region  Special Birth Mark Body Part Position
        [HttpGet]
        public async Task<IActionResult> SpecialBirthMarkBodyPartPosition()
        {
            ExtendedMasterDataViewModel model = new ExtendedMasterDataViewModel
            {
                specialBirthMarkBodyPartPositions = await _extendedMasterDataService.GetAllSpecialBirthMarkBodyPartPosition(),
                fLang = _lang.PerseLang("MasterData/ExtendedMasterDataEN.json", "MasterData/ExtendedMasterDataBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SpecialBirthMarkBodyPartPosition([FromForm] ExtendedMasterDataViewModel model)
        {
            SpecialBirthMarkBodyPartPosition partPosition = new SpecialBirthMarkBodyPartPosition
            {
                Id = (int)model.id,
                typeName = model.nameEnglish,
                typeNameBn = model.nameBangla

            };
            await _extendedMasterDataService.SaveSpecialBirthMarkBodyPartPosition(partPosition);
            return RedirectToAction(nameof(SpeechInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteSpecialBirthMarkBodyPartPositionById(int id)
        {
            var result = await _extendedMasterDataService.DeleteSpecialBirthMarkBodyPartPositionById(id);
            return Json(result);
        }

        #endregion

    }
}