using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class GDType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string gdTypeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string gdTypeNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
