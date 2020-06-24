using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using System.Collections.Generic;

namespace LostAndFound.Api.Models
{
    public class MDOtherItemInformation
    {
        public IEnumerable<ElectronicsType> electronicsTypes { get; set; }
        public IEnumerable<FileDocumentType> fileDocumentTypes { get; set; }
        public IEnumerable<MobilePhoneType> mobilePhoneTypes { get; set; }
        public IEnumerable<OtherBrand> mobileBrands { get; set; }
        public IEnumerable<OtherBrand> watchBrands { get; set; }
        public IEnumerable<OtherBrand> shoesBrands { get; set; }
        public IEnumerable<OtherBrand> bagBrands { get; set; }
        public IEnumerable<OtherBrand> electronicsBrands { get; set; }
        public IEnumerable<OtherBrand> jwellaryBrands { get; set; }
        public IEnumerable<OtherBrand> glassBrands { get; set; }
        public IEnumerable<OtherBrand> umbrellaBrands { get; set; }
        public IEnumerable<OperatingSystemType> operatingSystemTypes { get; set; }
    }
}
