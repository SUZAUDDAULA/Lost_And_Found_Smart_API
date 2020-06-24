using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class VehicleModel:Base
    {
        public int? vehicleTypeId { get; set; }
        public VehicleType vehicleType { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string modelName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string modelNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
