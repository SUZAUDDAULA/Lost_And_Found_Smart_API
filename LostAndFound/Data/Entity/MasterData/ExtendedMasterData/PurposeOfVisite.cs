using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class PurposeOfVisite:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string purposeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string purposeNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
