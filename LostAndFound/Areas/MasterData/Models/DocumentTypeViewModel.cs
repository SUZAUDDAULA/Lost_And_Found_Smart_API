using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.MasterData.Models
{
    public class DocumentTypeViewModel
    {
        public int? documentTypeId { get; set; }
        public string documentTypeName { get; set; }
        public string documentTypeNameBn { get; set; }
        public int? documentcategoryId { get; set; }
        public string documentCategoryName { get; set; }
        public string documentCategoryNameBn { get; set; }
        public int? shortOrder { get; set; }

        public IFormFile formFile { get; set; }
        public DocumentTypeLn fLang { get; set; }
        public IEnumerable<DocumentType> documentTypes { get; set; }
        public IEnumerable<DocumentCategory> documentCategories { get; set; }
        public IEnumerable<DocumentCategoryBrand> documentCategoryBrands { get; set; }
        public IEnumerable<DocumentCategoryAccessories> documentCategoryAccessories { get; set; }
        public IEnumerable<ComputerAccessoriesBrand> computerAccessoriesBrands { get; set; }
        
    }
}
