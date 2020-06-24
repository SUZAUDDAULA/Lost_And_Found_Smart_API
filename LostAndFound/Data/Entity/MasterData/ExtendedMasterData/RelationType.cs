using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class RelationType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string relationName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string relationNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
