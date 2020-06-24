using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Api.Models
{
    public class VehicleMasterDataAPIModel
    {
        public IEnumerable<VehicleType> vehicleTypes { get; set; }
        public IEnumerable<VehicleModel> vehicleModels { get; set; }
        public IEnumerable<RegistrationLevel> registrationLevels { get; set; }
        public IEnumerable<MetropolitanArea> metropolitanAreas { get; set; }
        public IEnumerable<District> districts { get; set; }
        public IEnumerable<Thana> thanas { get; set; }
        public IEnumerable<Colors> colors { get; set; }
        public IEnumerable<NationalIdentityType> nationalIdentityTypes { get; set; }
       
    }
}
