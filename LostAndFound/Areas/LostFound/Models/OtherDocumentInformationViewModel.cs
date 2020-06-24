using Microsoft.AspNetCore.Http;

namespace LostAndFound.Areas.LostFound.Models
{
    public class OtherDocumentInformationViewModel
    {
        public int? otherId { get; set; }
        public int? gDInformationId { get; set; }
        public int? documentTypeId { get; set; }
        public string typeName { get; set; }
        public string brandName { get; set; }
        public string modelName { get; set; }
        public string bodyType { get; set; }
        public string color { get; set; }
        public string structureType { get; set; }
        public string identificationMark { get; set; }
        public decimal? quantity { get; set; }
        public decimal? price { get; set; }
        public string description { get; set; }
        public IFormFile formFile { get; set; }
        public string attachment { get; set; }
    }
}
