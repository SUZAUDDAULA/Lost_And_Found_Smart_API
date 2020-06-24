using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class AgePeriod:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string periodName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string periodNameBn { get; set; }

        public int? shortOrder { get; set; }
    }
}
