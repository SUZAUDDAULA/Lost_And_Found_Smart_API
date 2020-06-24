using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class NationalIdentityType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string nationalIdentityName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string nationalIdentityNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
