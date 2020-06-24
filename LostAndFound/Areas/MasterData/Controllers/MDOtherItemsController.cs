using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.MasterData.Models;
using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using LostAndFound.Helpers;
using LostAndFound.Services.MasterData.Interfaces.MDOtherItems;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.MasterData.Controllers
{
    [Area("MasterData")]
    public class MDOtherItemsController : Controller
    {
        private readonly IElectronicService electronicService;

        public MDOtherItemsController(IElectronicService electronicService)
        {
            this.electronicService = electronicService;
        }

        #region ElectronicsType

        [HttpGet]
        public async Task<IActionResult> ElectronicsType()
        {
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                electronicsTypes = await electronicService.GetAllElectronicsType()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ElectronicsType([FromForm] MDOtherItemViewModel model)
        {
           
            ElectronicsType type = new ElectronicsType
            {
                Id = (int)model.id,
                typeName = model.typeName,
                typeNameBn = model.typeNameBn,
                shortOrder = model.shortOrder

            };
            await electronicService.SaveElectronicsType(type);
            return RedirectToAction(nameof(ElectronicsType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteElectronicsType(int id)
        {
            var result = await electronicService.DeleteElectronicsTypeById(id);
            return Json(result);
        }

        #endregion

        #region FileDocumentType

        [HttpGet]
        public async Task<IActionResult> FileDocumentType()
        {
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                fileDocumentTypes = await electronicService.GetAllFileDocumentType(),
                
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> FileDocumentType([FromForm] MDOtherItemViewModel model)
        {

            FileDocumentType type = new FileDocumentType
            {
                Id = (int)model.id,
                typeName = model.typeName,
                typeNameBn = model.typeNameBn,
                shortOrder = model.shortOrder

            };
            await electronicService.SaveFileDocumentType(type);
            return RedirectToAction(nameof(FileDocumentType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteFileDocumentType(int id)
        {
            var result = await electronicService.DeleteFileDocumentTypeById(id);
            return Json(result);
        }

        #endregion

        #region MobilePhoneType

        [HttpGet]
        public async Task<IActionResult> MobilePhoneType()
        {
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                mobilePhoneTypes = await electronicService.GetAllMobilePhoneType(),

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> MobilePhoneType([FromForm] MDOtherItemViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/MDOtherItem", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            MobilePhoneType type = new MobilePhoneType
            {
                Id = (int)model.id,
                typeName = model.typeName,
                typeNameBn = model.typeNameBn,
                shortOrder = model.shortOrder,
                imagePath = attachPath

            };
            await electronicService.SaveMobilePhoneType(type);
            return RedirectToAction(nameof(MobilePhoneType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteMobilePhoneType(int id)
        {
            var result = await electronicService.DeleteMobilePhoneTypeById(id);
            return Json(result);
        }

        #endregion

        #region OtherBrand

        [HttpGet]
        public async Task<IActionResult> OtherBrandMobile()
        {
            string brandFor = "mobile";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandWatch()
        {
            string brandFor = "watch";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandShoes()
        {
            string brandFor = "shoes";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandBag()
        {
            string brandFor = "bag";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandelEctronics()
        {
            string brandFor = "electronics";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandelJwellary()
        {
            string brandFor = "jwellary";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandelGlass()
        {
            string brandFor = "glass";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> OtherBrandelUmbrella()
        {
            string brandFor = "umbrella";
            MDOtherItemViewModel model = new MDOtherItemViewModel
            {
                otherBrands = await electronicService.GetAllOtherBrand(brandFor),

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> OtherBrand([FromForm] MDOtherItemViewModel model)
        {
            string attachPath = string.Empty;
            if (model.img != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/MDOtherItem", model.img);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }

            OtherBrand type = new OtherBrand
            {
                Id = (int)model.id,
                brandName = model.typeName,
                brandNameBn = model.typeNameBn,
                brandFor = model.brandFor,
                shortOrder = model.shortOrder,
                imagePath = attachPath

            };
            await electronicService.SaveOtherBrand(type);

            if(model.brandFor == "mobile")
            {
                return RedirectToAction(nameof(OtherBrandMobile));
            }
            else if(model.brandFor == "watch")
            {
                return RedirectToAction(nameof(OtherBrandWatch));
            }
            else if (model.brandFor == "shoes")
            {
                return RedirectToAction(nameof(OtherBrandShoes));
            }
            else if (model.brandFor == "bag")
            {
                return RedirectToAction(nameof(OtherBrandBag));
            }
            else if (model.brandFor == "electronics")
            {
                return RedirectToAction(nameof(OtherBrandelEctronics));
            }
            else if (model.brandFor == "jwellary")
            {
                return RedirectToAction(nameof(OtherBrandelJwellary));
            }
            else if (model.brandFor == "glass")
            {
                return RedirectToAction(nameof(OtherBrandelGlass));
            }
            else if (model.brandFor == "umbrella")
            {
                return RedirectToAction(nameof(OtherBrandelUmbrella));
            }
            else
            {
                return RedirectToAction(nameof(OtherBrandMobile));
            }

        }

        [HttpPost]
        public async Task<JsonResult> DeleteOtherBrand(int id)
        {
            var result = await electronicService.DeleteOtherBrandById(id);
            return Json(result);
        }

        #endregion
    }
}