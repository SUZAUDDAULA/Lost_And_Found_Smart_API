using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class VehicleInformationViewModel
    {
        public int? vehicleTypeId { get; set; }
        public string vehicleTypeName { get; set; }
        public string vehicleTypeNameBn { get; set; }
        public int? modelId { get; set; }
        public string modelName { get; set; }
        public string modelNameBn { get; set; }
        public IFormFile formFile { get; set; }
        public VehicleInformationLn fLang { get; set; }
        public IEnumerable<VehicleType> vehicleTypes { get; set; }
        public IEnumerable<VehicleModel> vehicleModels { get; set; }
    }
}
