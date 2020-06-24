using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class ProductTypeViewModel
    {
        public int? productTypeId { get; set; }
        public string productTypeName { get; set; }
        public string productTypeNameBn { get; set; }
        public IFormFile formFile { get; set; }
        public ProductTypeLn fLang { get; set; }
        public IEnumerable<ProductType> productTypes { get; set; }
    }
}
