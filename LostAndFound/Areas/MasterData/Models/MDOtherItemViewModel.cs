using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.MasterData.Models
{
    public class MDOtherItemViewModel
    {
        public int? id { get; set; }
        public string typeName { get; set; }
        public string typeNameBn { get; set; }
        public int? shortOrder { get; set; }
        public string brandFor { get; set; }
        public IFormFile img { get; set; }

        public IEnumerable<ElectronicsType> electronicsTypes { get; set; }
        public IEnumerable<FileDocumentType> fileDocumentTypes { get; set; }
        public IEnumerable<MobilePhoneType> mobilePhoneTypes { get; set; }
        public IEnumerable<OtherBrand> otherBrands { get; set; }
    }
}
