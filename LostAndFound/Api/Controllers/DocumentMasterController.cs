using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Api.Models;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DocumentMasterController : ControllerBase
    {
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly IAddressService addressService;

        public DocumentMasterController(ILostAndFoundType lostAndFoundType, IAddressService addressService)
        {
            this.lostAndFoundType = lostAndFoundType;
            this.addressService = addressService;
        }
        
        // GET: api/DocumentMaster/GetAllDocumentType
        [HttpGet]
        public async Task<IEnumerable<DocumentType>> GetAllDocumentType()
        {

            var documentTypes = await lostAndFoundType.GetDocumentTypes();

            return documentTypes;
        }

        // GET: api/DocumentMaster/GetDocumentCategoryByTypeId/4
        [HttpGet("{id}")]
        public async Task<IEnumerable<DocumentCategory>> GetDocumentCategoryByTypeId(int id)
        {
            var documentTypes = await lostAndFoundType.GetDocumentCategoryByTypeId(id);
            return documentTypes;
        }

        // GET: api/DocumentMaster/GetAllProductType
        [HttpGet]
        public async Task<IEnumerable<ProductType>> GetAllProductType()
        {

            var productTypes = await lostAndFoundType.GetProductType();

            return productTypes;
        }

        // GET: api/DocumentMaster/GetDocumentCategoryBrandByDocumentTypeId/4
        [HttpGet("{id}")]
        public async Task<IEnumerable<DocumentCategoryBrand>> GetDocumentCategoryBrandByDocumentTypeId(int id)
        {
            var documentCategoryBrands = await lostAndFoundType.GetDocumentCategoryBrandByDocumentTypeId(id);
            return documentCategoryBrands;
        }

        // GET: api/DocumentMaster/GetDocumentCategoryAccessoriesByDocumentTypeId/4
        [HttpGet("{id}")]
        public async Task<IEnumerable<DocumentCategoryAccessories>> GetDocumentCategoryAccessoriesByDocumentTypeId(int id)
        {
            var documentCategoryAccessories = await lostAndFoundType.GetDocumentCategoryAccessoriesByDocumentTypeId(id);
            return documentCategoryAccessories;
        }

        // GET: api/DocumentMaster/GetAllComputerAccessoriesBrand
        [HttpGet]
        public async Task<IEnumerable<ComputerAccessoriesBrand>> GetAllComputerAccessoriesBrand()
        {
            var computerAccessoriesBrands = await lostAndFoundType.GetAllComputerAccessoriesBrand();
            return computerAccessoriesBrands;
        }

        // GET: api/DocumentMaster/GetVehicleTypes
        [HttpGet]
        public async Task<IEnumerable<VehicleType>> GetVehicleTypes()
        {

            var vehicleTypes = await lostAndFoundType.GetVehicleTypes();

            return vehicleTypes;
        }

        // GET: api/DocumentMaster/GetVehicleModel
        [HttpGet]
        public async Task<IEnumerable<VehicleModel>> GetVehicleModel()
        {

            var vehicleModels = await lostAndFoundType.GetVehicleModel();

            return vehicleModels;
        }

        // GET: api/DocumentMaster/GetVehicleModelByVehicleId
        [HttpGet("{id}")]
        public async Task<IEnumerable<VehicleModel>> GetVehicleModelByVehicleId(int id)
        {
            var result = await lostAndFoundType.GetVehicleModelByVehicleId(id);
            return result;
        }

        // GET: api/DocumentMaster/GetGDTypes
        [HttpGet]
        public async Task<IEnumerable<GDType>> GetGDTypes()
        {

            var gDTypes = await lostAndFoundType.GetGDTypes();

            return gDTypes;
        }

        // GET: api/DocumentMaster/GetAnimals
        [HttpGet]
        public async Task<IEnumerable<Animal>> GetAnimals()
        {

            var animals = await lostAndFoundType.GetAnimals();

            return animals;
        }

        // GET: api/DocumentMaster/GetColors
        [HttpGet]
        public async Task<IEnumerable<Colors>> GetColors()
        {

            var colors = await lostAndFoundType.GetColors();

            return colors;
        }

        // GET: api/DocumentMaster/GetNationalIdentityTypes
        [HttpGet]
        public async Task<IEnumerable<NationalIdentityType>> GetNationalIdentityTypes()
        {

            var nationalIdentityTypes = await lostAndFoundType.GetNationalIdentityTypes();

            return nationalIdentityTypes;
        }

        // GET: api/DocumentMaster/GetOccupationInfo
        [HttpGet]
        public async Task<IEnumerable<Occupation>> GetOccupationInfo()
        {

            var occupations = await lostAndFoundType.GetOccupation();

            return occupations;
        }

        // GET: api/DocumentMaster/GetAllGender
        [HttpGet]
        public async Task<IEnumerable<Gender>> GetAllGender()
        {

            var genders = await lostAndFoundType.GetAllGender();

            return genders;
        }

        // GET: api/DocumentMaster/GetVehicleMasterData
        [HttpGet]
        public async Task<VehicleMasterDataAPIModel> GetVehicleMasterData()
        {
            VehicleMasterDataAPIModel model = new VehicleMasterDataAPIModel
            {
                //vehicleTypes = await lostAndFoundType.GetVehicleTypes(),
                vehicleModels = await lostAndFoundType.GetVehicleModel(),
                registrationLevels = await lostAndFoundType.GetRegistrationLevel(),
                metropolitanAreas = await lostAndFoundType.GetMetropolitanArea(),
                //colors = await lostAndFoundType.GetColors(),
                //districts =await addressService.GetAllDistrict(),
                //thanas=await addressService.GetAllThana(),
                //nationalIdentityTypes=await lostAndFoundType.GetNationalIdentityTypes()
            };
            return model;
        }

       

    }
}