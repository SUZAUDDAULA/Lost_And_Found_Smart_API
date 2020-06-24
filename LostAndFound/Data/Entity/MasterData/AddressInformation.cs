using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.Master;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class AddressInformation:Base
    {
        public String ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int? manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public int? countryId { get; set; }
        public Country country { get; set; }
        public int? divisionId { get; set; }
        public Division division { get; set; }
        public int? districtId { get; set; }
        public District district { get; set; }
        public int? thanaId { get; set; }
        public Thana thana { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string union { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string postOffice { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string postCode { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string blockSector { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string houseVillage { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string roadNumber { get; set; }
        [Column(TypeName = "NVARCHAR(250)")]
        public string addressDetails { get; set; }
        [Column(TypeName = "NVARCHAR(200)")]
        public string oneLineAddress { get; set; }
        //Type: Permamnent or Present
        
        [Column(TypeName = "NVARCHAR(50)")]
        public string type { get; set; }
    }
}
