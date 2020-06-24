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
using Microsoft.AspNetCore.Routing;

namespace LostAndFound.Areas.MasterData.Controllers
{
    [Authorize]
    [Area("MasterData")]
    public class MasterInformationController : Controller
    {
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly LangGenerate<DocumentTypeLn> _lang;
        private readonly LangGenerate<GDTypeLn> _gLang;
        private readonly LangGenerate<AnimalLn> _aLang;
        private readonly LangGenerate<ColorLn> _cLang;
        private readonly LangGenerate<NationalIdentityTypeLn> _nLang;
        private readonly LangGenerate<ProductTypeLn> _pLang;
        private readonly LangGenerate<OccupationLn> _oLang;

        public MasterInformationController(ILostAndFoundType lostAndFoundType, IHostingEnvironment hostingEnvironment)
        {
            this.lostAndFoundType = lostAndFoundType;
            _hostingEnvironment = hostingEnvironment;
            _lang = new LangGenerate<DocumentTypeLn>(_hostingEnvironment.ContentRootPath);
            _gLang = new LangGenerate<GDTypeLn>(_hostingEnvironment.ContentRootPath);
            _aLang = new LangGenerate<AnimalLn>(_hostingEnvironment.ContentRootPath);
            _cLang = new LangGenerate<ColorLn>(_hostingEnvironment.ContentRootPath);
            _nLang = new LangGenerate<NationalIdentityTypeLn>(_hostingEnvironment.ContentRootPath);
            _pLang = new LangGenerate<ProductTypeLn>(_hostingEnvironment.ContentRootPath);
            _oLang = new LangGenerate<OccupationLn>(_hostingEnvironment.ContentRootPath);
        }

        #region Document Type
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            DocumentTypeViewModel model = new DocumentTypeViewModel
            {
                documentTypes = await lostAndFoundType.GetDocumentTypes(),
                fLang = _lang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] DocumentTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentType", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DocumentType documentType = new DocumentType
            {
                Id = (int)model.documentTypeId,
                documentTypeName = model.documentTypeName,
                documentTypeNameBn=model.documentTypeNameBn,
                shortOrder=model.shortOrder,
                imagePath=attachPath
            };
            await lostAndFoundType.SaveDocumentType(documentType);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDocumentTypeById(int id)
        {
            var result = await lostAndFoundType.DeleteDocumentTypeById(id);
            return Json(result);
        }
        #endregion

        #region Document Category
        [HttpGet]
        public async Task<IActionResult> DocumentCategory()
        {
            DocumentTypeViewModel model = new DocumentTypeViewModel
            {
                documentTypes = await lostAndFoundType.GetDocumentTypes(),
                documentCategories = await lostAndFoundType.GetDocumentCategory(),
                fLang = _lang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DocumentCategory([FromForm] DocumentTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentCategory", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DocumentCategory documentCategory = new DocumentCategory
            {
                Id = (int)model.documentcategoryId,
                documentTypeId=model.documentTypeId,
                categoryName = model.documentCategoryName,
                categoryNameBn = model.documentCategoryNameBn,
                imagePath = attachPath
            };
            await lostAndFoundType.SaveDocumentCategory(documentCategory);
            return RedirectToAction(nameof(DocumentCategory));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteGetDocumentCategoryById(int id)
        {
            var result = await lostAndFoundType.DeleteGetDocumentCategoryById(id);
            return Json(result);
        }
        #endregion

        #region Document Category Brand
        [HttpGet]
        public async Task<IActionResult> DocumentCategoryBrand(int id)
        {
            var documents =await lostAndFoundType.GetDocumentTypesById(id);
            DocumentTypeViewModel model = new DocumentTypeViewModel
            {
                documentTypeId=id,
                documentTypeName= documents.documentTypeName,
                documentTypeNameBn = documents.documentTypeNameBn,
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(id),
                fLang = _lang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DocumentCategoryBrand([FromForm] DocumentTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentCategory", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DocumentCategoryBrand documentCategory = new DocumentCategoryBrand
            {
                Id = (int)model.documentcategoryId,
                documentTypeId = model.documentTypeId,
                brandName = model.documentCategoryName,
                brandNameBn = model.documentCategoryNameBn,
                imagePath = attachPath,
                shortOrder=model.shortOrder
            };
            await lostAndFoundType.SaveDocumentCategoryBrand(documentCategory);
            return RedirectToAction("DocumentCategoryBrand", new RouteValueDictionary(
    new { controller = "MasterInformation", action = "DocumentCategoryBrand", Id = model.documentTypeId }));
           // return RedirectToAction(nameof(DocumentCategoryBrand));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDocumentCategoryBrandById(int id)
        {
            var result = await lostAndFoundType.DeleteDocumentCategoryBrandById(id);
            return Json(result);
        }
        #endregion

        #region Document Category Accessories
        [HttpGet]
        public async Task<IActionResult> DocumentCategoryAccessories(int id)
        {
            var documents = await lostAndFoundType.GetDocumentTypesById(id);
            DocumentTypeViewModel model = new DocumentTypeViewModel
            {
                documentTypeId = id,
                documentTypeName = documents.documentTypeName,
                documentTypeNameBn = documents.documentTypeNameBn,
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(id),
                fLang = _lang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DocumentCategoryAccessories([FromForm] DocumentTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentCategory", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            DocumentCategoryAccessories documentCategory = new DocumentCategoryAccessories
            {
                Id = (int)model.documentcategoryId,
                documentTypeId = model.documentTypeId,
                accessoriesName = model.documentCategoryName,
                accessoriesNameBn = model.documentCategoryNameBn,
                imagePath = attachPath,
                shortOrder = model.shortOrder
            };
            await lostAndFoundType.SaveDocumentCategoryAccessories(documentCategory);
            return RedirectToAction("DocumentCategoryAccessories", new RouteValueDictionary(
   new { controller = "MasterInformation", action = "DocumentCategoryAccessories", Id = model.documentTypeId }));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDocumentCategoryDocumentCategoryAccessoriesById(int id)
        {
            var result = await lostAndFoundType.DeleteDocumentCategoryDocumentCategoryAccessoriesById(id);
            return Json(result);
        }
        #endregion

        #region Computer Accessories Brand
        [HttpGet]
        public async Task<IActionResult> ComputerAccessoriesBrand()
        {
            DocumentTypeViewModel model = new DocumentTypeViewModel
            {
                computerAccessoriesBrands = await lostAndFoundType.GetAllComputerAccessoriesBrand(),
                fLang = _lang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ComputerAccessoriesBrand([FromForm] DocumentTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentCategory", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            ComputerAccessoriesBrand computerAccessoriesBrand = new ComputerAccessoriesBrand
            {
                Id = (int)model.documentcategoryId,
                brandName = model.documentCategoryName,
                brandNameBn = model.documentCategoryNameBn,
                imagePath=attachPath
            };
            await lostAndFoundType.SaveComputerAccessoriesBrand(computerAccessoriesBrand);
            return RedirectToAction(nameof(ComputerAccessoriesBrand));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteComputerAccessoriesBrandById(int id)
        {
            var result = await lostAndFoundType.DeleteComputerAccessoriesBrandById(id);
            return Json(result);
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GDTypeInfo()
        {
            GDTypeViewModel model = new GDTypeViewModel
            {
                gDTypes = await lostAndFoundType.GetGDTypes(),
                fLang = _gLang.PerseLang("MasterData/GDTypeEN.json", "MasterData/GDTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GDTypeInfo([FromForm] GDTypeViewModel model)
        {
            GDType gDType = new GDType
            {
                Id = (int)model.gdTypeId,
                gdTypeName = model.gdTypeName,
                gdTypeNameBn=model.gdTypeNameBn
            };
            await lostAndFoundType.SaveGDType(gDType);
            return RedirectToAction(nameof(GDTypeInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteGDTypeInfoById(int id)
        {
            var result = await lostAndFoundType.DeleteGDTypeById(id);
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> AnimalInfo()
        {
            AnimalViewModel model = new AnimalViewModel
            {
                animals = await lostAndFoundType.GetAnimals(),
                fLang = _aLang.PerseLang("MasterData/AnimalEN.json", "MasterData/AnimalBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AnimalInfo([FromForm] AnimalViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/DocumentCategory", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            Animal animal = new Animal
            {
                Id = (int)model.animalId,
                animalName = model.animalName,
                animalNameBn=model.animalNameBn,
                imagePath=attachPath
            };
            await lostAndFoundType.SaveAnimal(animal);
            return RedirectToAction(nameof(AnimalInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteAnimalInfoById(int id)
        {
            var result = await lostAndFoundType.DeleteAnimalById(id);
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> ColorInfo()
        {
            ColorViewModel model = new ColorViewModel
            {
                colors = await lostAndFoundType.GetColors(),
                fLang = _cLang.PerseLang("MasterData/ColorEN.json", "MasterData/ColorBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ColorInfo([FromForm] ColorViewModel model)
        {
            Colors colors = new Colors
            {
                Id = (int)model.colorId,
                colorName = model.colorName,
                colorCode = model.colorCode,
                colorNameBn=model.colorNameBn
            };
            await lostAndFoundType.SaveColors(colors);
            return RedirectToAction(nameof(ColorInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteColorInfoById(int id)
        {
            var result = await lostAndFoundType.DeleteColorById(id);
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> NationalIdentityType()
        {
            NationalIdentityTypeViewModel model = new NationalIdentityTypeViewModel
            {
                nationalIdentityTypes = await lostAndFoundType.GetNationalIdentityTypes(),
                fLang = _nLang.PerseLang("MasterData/IdentityTypeEN.json", "MasterData/IdentityTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NationalIdentityType([FromForm] NationalIdentityTypeViewModel model)
        {
            NationalIdentityType nationalIdentityType = new NationalIdentityType
            {
                Id = (int)model.nidId,
                nationalIdentityName = model.nidName,
                nationalIdentityNameBn=model.nationalIdentityNameBn
            };
            await lostAndFoundType.SaveNationalIdentityType(nationalIdentityType);
            return RedirectToAction(nameof(NationalIdentityType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteNationalIdentityTypeById(int id)
        {
            var result = await lostAndFoundType.DeleteNatinoalIdentityTypeById(id);
            return Json(result);
        }
        #region Product Type
        [HttpGet]
        public async Task<IActionResult> ProductType()
        {
            ProductTypeViewModel model = new ProductTypeViewModel
            {
                productTypes = await lostAndFoundType.GetProductType(),
                fLang = _pLang.PerseLang("MasterData/ProductTypeEN.json", "MasterData/ProductTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductType([FromForm] ProductTypeViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/ProductType", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            ProductType productType = new ProductType
            {
                Id = (int)model.productTypeId,
                productTypeName = model.productTypeName,
                productTypeNameBn=model.productTypeNameBn,
                imagePath=attachPath
            };
            await lostAndFoundType.SaveProductType(productType);
            return RedirectToAction(nameof(ProductType));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteProductTypeById(int id)
        {
            var result = await lostAndFoundType.DeleteProductTypeById(id);
            return Json(result);
        }

        #endregion

        #region Occupation
        [HttpGet]
        public async Task<IActionResult> OccupationInfo()
        {
            OccupationViewModel model = new OccupationViewModel
            {
                occupations = await lostAndFoundType.GetOccupation(),
                fLang = _oLang.PerseLang("MasterData/DocumentTypeEN.json", "MasterData/DocumentTypeBN.json", Request.Cookies["lang"]),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> OccupationInfo([FromForm] OccupationViewModel model)
        {
            string attachPath = string.Empty;
            if (model.formFile != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/OccupationFile", model.formFile);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }
            Occupation occupation = new Occupation
            {
                Id = (int)model.occupationId,
                name = model.name,
                nameBn=model.nameBn,
                imagePath = attachPath
            };
            await lostAndFoundType.SaveOccupation(occupation);
            return RedirectToAction(nameof(OccupationInfo));
        }

        [HttpPost]
        public async Task<JsonResult> DeleteOccupationById(int id)
        {
            var result = await lostAndFoundType.DeleteOccupationById(id);
            return Json(result);
        }

        #endregion

    }
}