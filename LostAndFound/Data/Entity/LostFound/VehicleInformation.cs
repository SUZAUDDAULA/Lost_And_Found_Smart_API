using LostAndFound.Data.Entity.MasterData;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class VehicleInformation:Base
    {
        public int gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? vehicleTypeId { get; set; }
        public VehicleType vehicleType { get; set; }
        public int? vehicleBrandId { get; set; }
        public VehicleModel vehicleBrand { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string vehicleRegNo { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string regNoFirstPart { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string regNoSecondPart { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string regNoThiredPart { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string madeBy { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string madeIn { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string modelNo { get; set; }
        public DateTime? mfcDate { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string engineNo { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string chasisNo { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string ccNo { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string vehicleModelNo { get; set; }

        [Column(TypeName = "NVARCHAR(900)")]
        public string vehicleDescription { get; set; }
        [NotMapped]
        public IndentifyInfo indentifyInfo { get; set; }
        [NotMapped]
        public SpaceAndTime spaceAndTime { get; set; }
    }
}
