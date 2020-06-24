using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.Lang.ReportORApplication.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.MDOtherItems;

namespace LostAndFound.Models
{
    public class LostAndFoundMasterDataViewModel
    {
        public int? entryFor { get; set; }
        public int? gdTypeId { get; set; }
        public int? productTypeId { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string gdTypeName { get; set; }

        public ApplicationLangViewModel Lang { get; set; }

        public IEnumerable<NationalIdentityType> NationalIdentityTypes { get; set; }
        public IEnumerable<DocumentType> DocumentTypes { get; set; }
        public IEnumerable<VehicleType> VehicleTypes { get; set; }
        public IEnumerable<Colors> Colors { get; set; }
        public IEnumerable<Animal> animals { get; set; }
        public IEnumerable<ManBodyPart> ManBodyParts { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<GDType> GdTypes { get; set; }
        public IEnumerable<Division> Divisions { get; set; }
        public IEnumerable<District> Districts { get; set; }
        public IEnumerable<Thana> Thanas { get; set; }
        public IEnumerable<Country> countries { get; set; }
        public IEnumerable<PostOffice> PostOffices { get; set; }
        public IEnumerable<MetropolitanArea> metropolitanAreas { get; set; }
        public IEnumerable<RegistrationLevel> registrationLevels { get; set; }
        public IEnumerable<DocumentCategoryBrand> documentCategoryBrands { get; set; }
        public IEnumerable<DocumentCategoryAccessories> documentCategoryAccessories { get; set; }
        public IEnumerable<MobilePhoneType> mobilePhoneTypes { get; set; }
        public IEnumerable<ElectronicsType> electronicsTypes { get; set; }

        public GDInformation gDInformation { get; set; }
        public VehicleInformation vehicleInformation { get; set; }
        public IndentifyInfo indentifyInfo { get; set; }
        public OtherPersonInformation otherPersonInformation { get; set; }
        public SpaceAndTime spaceAndTime { get; set; }
        public ApplicationUser applicationUser { get; set; }


    }
}
