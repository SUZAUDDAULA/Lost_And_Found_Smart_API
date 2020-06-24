namespace LostAndFound.Areas.ReportORApplication.Models
{
    public class GDViewModel
    {
        public int? gdTypeId { get; set; }
        public int? vehicleTypeId { get; set; }
        public int? vehicleBrandId { get; set; }
        public string vehicleRegNo { get; set; }
        public string regNoFirstPart { get; set; }
        public string regNoSecondPart { get; set; }
        public string regNoThiredPart { get; set; }
        public string modelNo { get; set; }
        public string vehicleDescription { get; set; }
        public string engineNo { get; set; }
       

        public byte[] encodedImage { get; set; }
        public string userName { get; set; }

    }

    
}
