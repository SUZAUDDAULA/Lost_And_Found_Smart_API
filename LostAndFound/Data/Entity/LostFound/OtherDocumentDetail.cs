using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class OtherDocumentDetail:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? documentTypeId { get; set; }
        public DocumentType documentType { get; set; }
        public int? documentCategoryBrandId { get; set; }
        public DocumentCategoryBrand documentCategoryBrand { get; set; }
        public int? mobilePhoneTypeId { get; set; }
        public MobilePhoneType mobilePhoneType { get; set; }
        public int? electronicsTypeId { get; set; }
        public ElectronicsType electronicsType { get; set; }
        public int? fileDocumentTypeId { get; set; }
        public FileDocumentType fileDocumentType { get; set; }
        public int? otherBrandId { get; set; }
        public OtherBrand otherBrand { get; set; }
        public int? operatingSystemTypeId { get; set; }
        public OperatingSystemType operatingSystemType { get; set; }
        public int? colorsId { get; set; }
        public Colors colors { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string typeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string modelName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string serialNo { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string productNumber { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string currency { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? screenSize { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? price { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string battery { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string ram { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string rom { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string macAddress { get; set; }
        [Column(TypeName = "NVARCHAR(350)")]
        public string description { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string attachment { get; set; }
    }
}
