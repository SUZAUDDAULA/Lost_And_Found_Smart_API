using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class ProductType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string productTypeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string productTypeNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
