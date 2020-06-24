using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class VehicleMasterController : ControllerBase
    {
        private readonly ILostAndFoundType lostAndFoundType;

        public VehicleMasterController(ILostAndFoundType lostAndFoundType)
        {
            this.lostAndFoundType = lostAndFoundType;
        }

        // GET: api/VehicleMaster/GetAllVehicleType
        [HttpGet]
        public async Task<IEnumerable<VehicleType>> GetAllVehicleType()
        {

            var vehicleTypes = await lostAndFoundType.GetVehicleTypes();
            
            return vehicleTypes;
        }

        // GET: api/VehicleMaster/GetAllVehicleModel
        [HttpGet]
        public async Task<IEnumerable<VehicleModel>> GetAllVehicleModel()
        {

            var vehicleModels = await lostAndFoundType.GetVehicleModel();

            return vehicleModels;
        }

        // GET: api/VehicleMaster/GetAllMetropolitanArea
        [HttpGet]
        public async Task<IEnumerable<MetropolitanArea>> GetAllMetropolitanArea()
        {

            var metropolitanAreas = await lostAndFoundType.GetMetropolitanArea();

            return metropolitanAreas;
        }

        // GET: api/VehicleMaster/GetAllRegistrationLevel
        [HttpGet]
        public async Task<IEnumerable<RegistrationLevel>> GetAllRegistrationLevel()
        {

            var registrationLevels = await lostAndFoundType.GetRegistrationLevel();

            return registrationLevels;
        }

    }
}