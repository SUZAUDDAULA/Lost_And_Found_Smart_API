using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class VehicleType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string vehicleTypeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string vehicleTypeNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
