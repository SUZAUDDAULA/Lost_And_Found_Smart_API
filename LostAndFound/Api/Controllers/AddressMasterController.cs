using LostAndFound.Api.Models;
using LostAndFound.Data.Entity.Master;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressMasterController : ControllerBase
    {
        private readonly IAddressService addressService;
        private readonly ILostAndFoundType lostAndFoundType;

        public AddressMasterController(IAddressService addressService, ILostAndFoundType lostAndFoundType)
        {
            this.addressService = addressService;
            this.lostAndFoundType = lostAndFoundType;
        }

        // GET: api/AddressMaster/GetAllContry
        [HttpGet]
        public async Task<IEnumerable<Country>> GetAllContry()
        {

            var countries = await addressService.GetAllContry();

            return countries;
        }

        // GET: api/AddressMaster/GetDivisions
        [HttpGet]
        public async Task<IEnumerable<Division>> GetDivisions()
        {

            var divisions = await addressService.GetAllDivision();

            return divisions;
        }

        // GET: api/AddressMaster/GetAllDistrict
        [HttpGet]
        public async Task<IEnumerable<District>> GetAllDistrict()
        {

            var districts = await addressService.GetAllDistrict();

            return districts;
        }

        // GET: api/AddressMaster/GetDistrictByDivisionId
        [HttpGet("{id}")]
        public async Task<IEnumerable<District>> GetDistrictByDivisionId(int id)
        {

            var districts = await addressService.GetDistrictsByDivisonId(id);

            return districts;
        }

        // GET: api/AddressMaster/GetThanaByDistrictId
        [HttpGet("{id}")]
        public async Task<IEnumerable<Thana>> GetThanaByDistrictId(int id)
        {
            var thanas = await addressService.GetThanasByDistrictId(id);

            return thanas;
        }

        // GET: api/AddressMaster/GetPostOfficeByDistrictId
        [HttpGet("{id}")]
        public async Task<IEnumerable<PostOffice>> GetPostOfficeByDistrictId(int id)
        {
            var postOffices = await addressService.GetPostOfficeByDistrictId(id);

            return postOffices;
        }

        // GET: api/AddressMaster/GetAddressInformationMasterData
        [HttpGet]
        public async Task<MDAddressInforamtionModel> GetAddressInformationMasterData()
        {
            MDAddressInforamtionModel model = new MDAddressInforamtionModel
            {
                nationalIdentityTypes=await lostAndFoundType.GetNationalIdentityTypes(),
                countries = await addressService.GetAllContry(),
                divisions = await addressService.GetAllDivision(),
                districts = await addressService.GetAllDistrict(),
                thanas = await addressService.GetAllThana(),
            };
            return model;
        }

    }
}