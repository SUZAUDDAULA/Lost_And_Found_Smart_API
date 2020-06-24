using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class Country : Base
    {
        [Required]
        [Column(TypeName = "NVARCHAR(20)")]
        public string countryCode { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(120)")]
        public string countryName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string countryNameBn { get; set; }

        [Column(TypeName = "NVARCHAR(20)")]
        public string shortName { get; set; }

    }
}
