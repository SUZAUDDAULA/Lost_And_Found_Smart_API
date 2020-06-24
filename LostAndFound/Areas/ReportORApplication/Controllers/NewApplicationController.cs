using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using LostAndFound.Areas.Auth.Models;
using LostAndFound.Areas.Lang.ReportORApplication.Models;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Areas.ReportORApplication.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Helpers;
using LostAndFound.Models;
using LostAndFound.Services.LostFoundServices.Interfaces;
using LostAndFound.Services.MasterData.Interfaces;
using LostAndFound.Services.MasterData.Interfaces.MDOtherItems;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Areas.ReportORApplication.Controllers
{
    [Authorize]
    [Area("ReportORApplication")]
    public class NewApplicationController : Controller
    {
        private readonly LangGenerate<ApplicationLangViewModel> _lang;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IElectronicService electronicService;
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly ILostAndFoundService lostAndFoundService;
        private readonly IAddressService addressService;
        private readonly IAddressInformationService addressInformationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly string rootPath;
        private readonly MyPDF myPDF;
        public string FileName;
        public NewApplicationController(IHostingEnvironment hostingEnvironment, IElectronicService electronicService, IAddressService addressService, ILostAndFoundType lostAndFoundType
            , ILostAndFoundService lostAndFoundService, UserManager<ApplicationUser> userManager, IConverter converter,IAddressInformationService addressInformationService)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.lostAndFoundType = lostAndFoundType;
            this.addressService = addressService;
            this.lostAndFoundService = lostAndFoundService;
            this.electronicService = electronicService;
            this.addressInformationService = addressInformationService;
            _userManager = userManager;
            _lang = new LangGenerate<ApplicationLangViewModel>(hostingEnvironment.ContentRootPath);
            myPDF = new MyPDF(hostingEnvironment, converter);
            rootPath = hostingEnvironment.ContentRootPath;
        }
        public async Task<IActionResult> Index(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId=id,
                gdTypeName=gdType.gdTypeName,
                DocumentTypes =  await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas=await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels=await lostAndFoundType.GetRegistrationLevel(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Vehicle(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                countries = await addressService.GetAllContry(),
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Document(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Pets(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Computer(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(1),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> ComputerAccesorices(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(1),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(1),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Mobile(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(4),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(4),
                mobilePhoneTypes = await electronicService.GetAllMobilePhoneType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Electronics(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(3),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(3),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }


        public async Task<IActionResult> Cards(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(6),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(6),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Keys(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(5),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(5),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Money(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(5),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(5),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Bags(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(8),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(8),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Jewellery(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(10),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(10),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Glasses(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(11),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(11),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Garments(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(12),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(12),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Shoes(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(13),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(13),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Cosmetics(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(13),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(13),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Watch(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(2),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(2),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Umbrella(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(16),
                documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(16),
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        public async Task<IActionResult> Man(int? id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var gdType = await lostAndFoundType.GetGDTypesById(Convert.ToInt32(id));
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gdTypeId = id,
                gdTypeName = gdType.gdTypeName,
                DocumentTypes = await lostAndFoundType.GetDocumentTypes(),
                VehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                Colors = await lostAndFoundType.GetColors(),
                animals = await lostAndFoundType.GetAnimals(),
                ManBodyParts = await lostAndFoundType.GetManBodyPart(),
                ProductTypes = await lostAndFoundType.GetProductType(),
                Divisions = await addressService.GetAllDivision(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Index([FromForm] GDViewModel model)
        {
            //return Json(model);
            try
            {
                string userName = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(userName);
                int _min = 1000000;
                int _max = 9999999;
                Random _rdm = new Random();
                int gdCode = _rdm.Next(_min, _max);
                GDInformation gDInformation = new GDInformation
                {
                    ApplicationUserId = user.Id.ToString(),
                    gdFor = "Own",
                    gdDate = DateTime.Now,
                    gdNumber = gdCode.ToString(),
                    gDTypeId = 1,
                    productTypeId = 1,
                    //documentTypeId = model.documentTypeId == 0 ? null : model.documentTypeId,
                    //documentDescription = model.documentDescription,
                    statusId = 1
                };

                int gdId = await lostAndFoundService.SaveGDInformation(gDInformation);
                
                    VehicleInformation vehicleInformation = new VehicleInformation
                    {
                        gDInformationId = gdId,
                        vehicleTypeId = model.vehicleTypeId,
                        vehicleRegNo = model.vehicleRegNo,
                        regNoFirstPart = model.regNoFirstPart,
                        regNoSecondPart = model.regNoSecondPart,
                        regNoThiredPart = model.regNoThiredPart,
                        //madeBy = model.madeBy,
                        //madeIn = model.madeIn,
                        //modelNo = model.modelNo,
                        //mfcDate = model.mfcDate,
                        //engineNo = model.engineNo,
                        //chasisNo = model.chasisNo,
                        //ccNo = model.ccNo,
                        vehicleModelNo = model.modelNo
                    };

                    int vchid = await lostAndFoundService.SaveVehicleInformation(vehicleInformation);
                


                //if (model.gdFor == "2")
                //{
                //    OtherPersonInformation otherPerson = new OtherPersonInformation
                //    {
                //        gDInformationId = gdId,
                //        nationalIdentityTypeId = model.nationalIdentityTypeId == 0 ? null : model.nationalIdentityTypeId,
                //        identityNo = model.identityNo,
                //        mobileNo = model.mobileNo
                //    };
                //    int opi = await lostAndFoundService.SaveOtherPersonInformation(otherPerson);
                //}
                //string attachPath = string.Empty;
                //if (model.formFile != null)
                //{
                //    string fileName;
                //    string message = FileSave.SaveImage(out fileName, "Upload/Attachment", model.formFile);

                //    if (message == "success")
                //    {
                //        attachPath = fileName;
                //    }
                //}
                //IndentifyInfo indentifyInfo = new IndentifyInfo
                //{
                //    gDInformationId = gdId,
                //    colorsId = model.colorsId,
                //    identifySign = model.identifySign,
                //    attachmentPath = attachPath

                //};
                //int identityid = await lostAndFoundService.SaveIndentifyInfo(indentifyInfo);

                //SpaceAndTime spaceAndTime = new SpaceAndTime
                //{
                //    gDInformationId = gdId,
                //    placeDetails = model.placeDetails,
                //    lafDate = model.lafDate,
                //    lafTime = model.lafTime,
                //    postOfficeId = model.postOfficeId,
                //    thanaId = model.thanaId,
                //    districtId = model.districtId,
                //    divisionId = model.divisionId
                //};
                //int sdid = await lostAndFoundService.SaveSpaceAndTime(spaceAndTime);

                return RedirectToAction("GDDetailsView", "NewApplication", new { @id = gdId });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
        }
        [HttpGet]
        public StatusTypeViewModel GetCountGDInformationStatus()
        {
            //var user = _userManager.FindByNameAsync(userName);
            var result = lostAndFoundService.GetCountGDInformationStatus("asd");
            return result;
        }

        public async Task<IActionResult> GDDetailsView(int id)
        {
            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
               gDInformation=await lostAndFoundService.GetGDInformationById(id),
               vehicleInformation=await lostAndFoundService.GetVehicleInformationByGDId(id),
               otherPersonInformation=await lostAndFoundService.GetOtherPersonInformationByGDId(id),
               indentifyInfo=await lostAndFoundService.GetIndentifyInfoByGDId(id),
               spaceAndTime=await lostAndFoundService.GetSpaceAndTimeByGDId(id),
               applicationUser=user,
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return View(model);
        }

        //POST: api/LostFound/SaveGDManInformation
        [HttpPost]
        public async Task<IActionResult> SaveGDManInformation(GDManInformationViewModel model)
        {
            try
            {
                //var user = await _userManager.FindByNameAsync(model.userName);
                int _min = 1000000;
                int _max = 9999999;
                Random _rdm = new Random();
                int gdCode = _rdm.Next(_min, _max);
                GDInformation gDInformation = new GDInformation
                {
                    ApplicationUserId = "42925329-31ab-4805-8057-6f07bd9aaee5",
                    gdFor = model.gdFor,
                    gdDate = DateTime.Now,
                    gdNumber = gdCode.ToString(),
                    gDTypeId = model.gDTypeId,
                    productTypeId = model.productTypeId,
                    documentTypeId = model.documentTypeId == 0 ? null : model.documentTypeId,
                    documentDescription = model.documentDescription,
                    statusId = 1
                };

                int gdId = await lostAndFoundService.SaveGDInformation(gDInformation);


                ManInformation manInformation = new ManInformation
                {
                    gDInformationId = gdId,
                    relationTypeId = model.relationTypeId,
                    name = model.name,
                    aproxAge = model.aproxAge,
                    agePeriodId = model.agePeriodId,
                    genderId = model.genderId,
                    isHealthDisabled = model.isHealthDisabled,
                    fatherName = model.fatherName,
                    motherName = model.motherName,
                    spouseName = model.spouseName,
                    nationalIdentityTypeId = model.manNationalIdentityTypeId,
                    identityNo = model.identityNo,
                    numberTypeId = model.numberTypeId,
                    number = model.number
                };

                int manid = await lostAndFoundService.SaveManInformation(manInformation);

                if (model.gdFor == "OTHERS")
                {
                    OtherPersonInformation otherPerson = new OtherPersonInformation
                    {
                        gDInformationId = gdId,
                        nationalIdentityTypeId = model.nationalIdentityTypeId == 0 ? null : model.nationalIdentityTypeId,
                        identityNo = model.identityNo,
                        mobileNo = model.mobileNo
                    };
                    int opi = await lostAndFoundService.SaveOtherPersonInformation(otherPerson);
                }

                IndentifyInfo indentifyInfo = new IndentifyInfo
                {
                    gDInformationId = gdId,
                    colorsId = model.colorsId,
                    identifySign = model.identifySign,
                    descriptionCircumcisionId = model.descriptionCircumcisionId,
                    religionId = model.religionId,
                    bloodGroup = model.bloodGroup,
                    occupationId = model.occupationId,
                    maritalStatusId = model.maritalStatusId
                };
                int identityid = await lostAndFoundService.SaveIndentifyInfo(indentifyInfo);

                AddressInformation addressInformation = new AddressInformation
                {
                    districtId = model.manDistrictId,
                    thanaId = model.thanaId,
                    houseVillage = model.postOffice,
                    addressDetails = model.addressDetails,
                    type = model.addressType,
                    oneLineAddress = model.oneLineAddress,
                };
                int addressId = await addressInformationService.SaveAddressInformation(addressInformation);

                PhysicalDescription physical = new PhysicalDescription
                {
                    manInformationId = manid,
                    eyeTypeId = model.eyeTypeId,
                    noseTypeId = model.noseTypeId,
                    hairTypeId = model.hairTypeId,
                    foreHeadTypeId = model.foreHeadTypeId,
                    beardTypeId = model.beardTypeId,
                    weight = model.weight,
                    bodyStructureId = model.bodyStructureId,
                    faceShapeTypeId = model.faceShapeTypeId,
                    bodyChinTypeId = model.bodyChinTypeId,
                    bodyColorId = model.bodyColorId,
                    moustacheTypeId = model.moustacheTypeId,
                    earTypeId = model.earTypeId,
                    neckTypeId = model.neckTypeId,
                    heightFeet = model.heightFeet,
                    heightInch = model.heightInch,
                    specialBirthMarkTypeId = model.specialBirthMarkTypeId,
                    specialBirthMarkBodyPartId = model.specialBirthMarkBodyPartId,
                    specialBirthMarkBodyPartPositionId = model.specialBirthMarkBodyPartPositionId,
                    visibleTatto = model.visibleTatto,
                    otherIdentityfyMark = model.otherIdentityfyMark,
                    teethTypeId = model.teethTypeId,
                    specialBodyConditionId = model.specialBodyConditionId,

                };
                int phyId = await lostAndFoundService.SavePhysicalDescription(physical);

                DressDescription dress = new DressDescription
                {
                    manInformationId = manid,
                    inTheHeadId = model.inTheHeadId,
                    inTheHeadColorId = model.inTheHeadColorId,
                    inTheBodyId = model.inTheBodyId,
                    inTheBodyColorId = model.inTheBodyColorId,
                    inTheThroatId = model.inTheThroatId,
                    inTheThroatColorId = model.inTheThroatColorId,
                    inTheWaistId = model.inTheWaistId,
                    inTheWaistColorId = model.inTheWaistColorId,
                    inTheLegsId = model.inTheLegsId,
                    inTheLegsColorId = model.inTheLegsColorId,
                    inTheEyeId = model.inTheEyeId,
                    inTheEyeColorId = model.inTheEyeColorId,
                    shoesSize = model.shoesSize,
                    shoesSizeType = model.shoesSizeType,

                };
                int dressId = await lostAndFoundService.SaveDressDescription(dress);
                SpaceAndTime spaceAndTime = new SpaceAndTime
                {
                    gDInformationId = gdId,
                    placeDetails = model.placeDetails,
                    lafDate = model.lafDate,
                    lafTime = model.lafTime,
                    postOfficeId = model.postOfficeId,
                    thanaId = model.thanaId,
                    districtId = model.districtId,
                    divisionId = model.divisionId
                };
                int sdid = await lostAndFoundService.SaveSpaceAndTime(spaceAndTime);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        [AllowAnonymous]
        public IActionResult GDInformationView(int id)
        {
            string scheme = Request.Scheme;
            var host = Request.Host;
            string url = "";
            string fileName;
            url = scheme + "://" + host + "/ReportORApplication/NewApplication/GDInformationReport?id="+id;


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
        public async Task<IActionResult> GDInformationReport(int id)
        {
            var info = await lostAndFoundService.GetGDInformationById(id);
            var user = await _userManager.FindByIdAsync(info.ApplicationUserId);
            LostAndFoundMasterDataViewModel model = new LostAndFoundMasterDataViewModel
            {
                gDInformation = info,
                vehicleInformation = await lostAndFoundService.GetVehicleInformationByGDId(id),
                otherPersonInformation = await lostAndFoundService.GetOtherPersonInformationByGDId(id),
                indentifyInfo = await lostAndFoundService.GetIndentifyInfoByGDId(id),
                spaceAndTime = await lostAndFoundService.GetSpaceAndTimeByGDId(id),
                applicationUser = user,
                Lang = _lang.PerseLang("Application/ApplicationEN.json", "Application/ApplicationBN.json", Request.Cookies["lang"]),
            };

            return PartialView(model);
        }

    }
}