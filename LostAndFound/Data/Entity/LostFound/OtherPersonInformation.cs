using LostAndFound.Data.Entity.MasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class OtherPersonInformation:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? nationalIdentityTypeId { get; set; }
        public NationalIdentityType nationalIdentityType { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string identityNo { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string mobileNo { get; set; }
    }
}
