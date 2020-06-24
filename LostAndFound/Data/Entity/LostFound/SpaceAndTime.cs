using LostAndFound.Data.Entity.Master;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class SpaceAndTime:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? divisionId { get; set; }
        public Division division { get; set; }
        public int? districtId { get; set; }
        public District district { get; set; }
        public int? thanaId { get; set; }
        public Thana thana { get; set; }
        public int? postOfficeId { get; set; }
        public PostOffice postOffice { get; set; }
        [Column(TypeName = "NVARCHAR(200)")]
        public string village { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string placeDetails { get; set; }
        public DateTime? lafDate { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string lafTime { get; set; }
    }
}
