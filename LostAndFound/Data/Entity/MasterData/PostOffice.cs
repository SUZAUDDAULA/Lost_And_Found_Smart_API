using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class PostOffice : Base
    {
        public int districtId { get; set; }
        public District district { get; set; }

        [Column(TypeName = "NVARCHAR(20)")]
        public string postalCode { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string postalName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string postalShortName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string postalNameBn { get; set; }

        
    }
}
