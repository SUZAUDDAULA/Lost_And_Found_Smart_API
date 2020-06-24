using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class Thana : Base
    {
       [Column(TypeName ="NVARCHAR(20)")]
        public string thanaCode { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string thanaName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string thanaNameBn { get; set; }
        
        public int districtId { get; set; }

        public District district { get; set; }
    }
}
