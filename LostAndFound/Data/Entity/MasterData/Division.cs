using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class Division : Base
    {
        [Required]
        [Column(TypeName = "NVARCHAR(20)")]
        public string divisionCode { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(120)")]
        public string divisionName { get; set; }
        public string divisionNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }

        public int? countryId { get; set; }

        public Country country { get; set; }
    }
}
