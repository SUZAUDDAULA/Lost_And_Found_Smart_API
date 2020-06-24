using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class ComputerAccessoriesBrand:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
