using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class ReligionCust:Base
    {
        public int? religionId { get; set; }
        public Religion religion { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string custName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string custNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
