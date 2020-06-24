using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class MeterialCondition:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string conditionName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string conditionNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
