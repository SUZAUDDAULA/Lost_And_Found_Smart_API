using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.MDOtherItems
{
    public class OtherBrand:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandFor { get; set; } //mobile,watch,shoes,bag,electronics,jwellary,glass,umbrella
        public int? shortOrder { get; set; }
    }
}
