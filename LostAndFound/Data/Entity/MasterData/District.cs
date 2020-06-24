using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class District : Base
    {
        [Required]
        [Column(TypeName = "NVARCHAR(20)")]
        public string districtCode { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(120)")]
        public string districtName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string districtNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }

        public int divisionId { get; set; }

        public Division division { get; set; }
    }
}
