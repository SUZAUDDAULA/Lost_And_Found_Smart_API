using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Data
{
    public class LAFDbContext: IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LAFDbContext()
        {

        }
        public LAFDbContext(DbContextOptions<LAFDbContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }

        #region USER MANAGE
        public DbQuery<AspNetUsersViewModel> AspNetUsersViewModels { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserAccessPage> UserAccessPages { get; set; }
        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<LAFModule> LAFModules { get; set; }
        public DbSet<ModuleAccessPage> ModuleAccessPages { get; set; }
        public DbSet<MailLog> MailLogs { get; set; }
        public DbSet<UserLogHistory> UserLogHistories { get; set; }
        public DbQuery<NavbarViewModel> navbarViewModels { get; set; }
        public DbQuery<UserAccessPageViewModel> userAccessPageViewModels { get; set; }
        #endregion

        #region MasterData
        public DbSet<Country> Countries { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Thana> Thanas { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }
        public DbSet<ManBodyPart> ManBodyParts { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<LostAndFoundType> LostAndFoundTypes { get; set; }
        public DbSet<NationalIdentityType> NationalIdentityTypes { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentCategory> DocumentCategories { get; set; }
        public DbSet<DocumentCategoryBrand> DocumentCategoryBrands { get; set; }
        public DbSet<DocumentCategoryAccessories> DocumentCategoryAccessories { get; set; }
        public DbSet<ComputerAccessoriesBrand> ComputerAccessoriesBrands { get; set; }
        public DbSet<GDType> GDTypes { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<AttachmentType> AttachmentTypes { get; set; }
        public DbSet<AddressCategory> AddressCategories { get; set; }
        public DbSet<AttachmentInformation> AttachmentInformation { get; set; }

        public DbSet<MetropolitanArea> MetropolitanAreas { get; set; }
        public DbSet<RegistrationLevel> RegistrationLevels { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<StatusInfo> StatusInfos { get; set; }
        #endregion


        #region Extended Master Data
        public DbSet<AgePeriod> AgePeriods { get; set; }
        public DbSet<AddressSourceType> AddressSourceTypes { get; set; }
        public DbSet<BeardType> BeardTypes { get; set; }
        public DbSet<BodyChinType> BodyChinTypes { get; set; }
        public DbSet<BodyColor> BodyColors { get; set; }
        public DbSet<BodyStructure> BodyStructures { get; set; }
        public DbSet<CareType> CareTypes { get; set; }
        public DbSet<Complextion> Complextions { get; set; }
        public DbSet<DeadbodyCondition> DeadbodyConditions { get; set; }
        public DbSet<DeathType> DeathTypes { get; set; }
        public DbSet<EarType> EarTypes { get; set; }
        public DbSet<EyeType> EyeTypes { get; set; }
        public DbSet<FaceShapeType> FaceShapeTypes { get; set; }
        public DbSet<ForeHeadType> ForeHeadTypes { get; set; }
        public DbSet<HairType> HairTypes { get; set; }
        public DbSet<HeadType> HeadTypes { get; set; }
        public DbSet<InTheBody> InTheBodies { get; set; }
        public DbSet<InTheHead> InTheHeads { get; set; }
        public DbSet<InTheEye> InTheEyes { get; set; }
        public DbSet<InTheLegs> InTheLegs { get; set; }
        public DbSet<InTheThroat> InTheThroats { get; set; }
        public DbSet<InTheWaist> InTheWaists { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<MeterialCondition> MeterialConditions { get; set; }
        public DbSet<MoustacheType> MoustacheTypes { get; set; }
        public DbSet<MouthType> MouthTypes { get; set; }
        public DbSet<NeckType> NeckTypes { get; set; }
        public DbSet<NoseType> NoseTypes { get; set; }
        public DbSet<NumberType> NumberTypes { get; set; }
        public DbSet<PurposeOfVisite> PurposeOfVisites { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<ReligionCust> ReligionCusts { get; set; }
        public DbSet<SpecialBodyCondition> SpecialBodyConditions { get; set; }
        public DbSet<TeethType> TeethTypes { get; set; }
        public DbSet<RelationType> RelationTypes { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<Speech> Speeches { get; set; }
        public DbSet<SpecialBirthMarkType> SpecialBirthMarkTypes { get; set; }
        public DbSet<SpecialBirthMarkBodyPart> SpecialBirthMarkBodyParts { get; set; }
        public DbSet<SpecialBirthMarkBodyPartPosition> SpecialBirthMarkBodyPartPositions { get; set; }
        #endregion

        #region Other item Master Data
        public DbSet<OtherBrand> OtherBrands { get; set; }
        public DbSet<MobilePhoneType> MobilePhoneTypes { get; set; }
        public DbSet<FileDocumentType> FileDocumentTypes { get; set; }
        public DbSet<ElectronicsType> ElectronicsTypes { get; set; }
        public DbSet<OperatingSystemType> OperatingSystemTypes { get; set; }

        #endregion

        #region Lost & Found
        public DbSet<AddressInformation> AddressInformation { get; set; }
        public DbSet<GDInformation> GDInformation { get; set; }
        public DbSet<OtherPersonInformation> OtherPersonInformation { get; set; }
        public DbSet<VehicleInformation> VehicleInformation { get; set; }
        public DbSet<ManInformation> ManInformation { get; set; }
        public DbSet<SpaceAndTime> SpaceAndTimes { get; set; }
        public DbSet<IndentifyInfo> IndentifyInfos { get; set; }
        public DbSet<IdentificationAttachment> IdentificationAttachments { get; set; }
        public DbSet<OtherDocumentDetail> OtherDocumentDetails { get; set; }
        public DbSet<ManHabitDetails> ManHabitDetails { get; set; }
        public DbSet<ManSpeechDetails> ManSpeechDetails { get; set; }
        public DbSet<PhysicalDescription> PhysicalDescriptions { get; set; }
        public DbSet<DressDescription> DressDescriptions { get; set; }
        public DbSet<DNAProfileDetails> DNAProfileDetails { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Comments> Comments { get; set; }
        #endregion

        #region Settings Configs
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {

            var entities = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUsername = !string.IsNullOrEmpty(_httpContextAccessor?.HttpContext?.User?.Identity?.Name)
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((Base)entity.Entity).createdAt = DateTime.Now;
                    ((Base)entity.Entity).createdBy = currentUsername;
                }
                else
                {
                    entity.Property("createdAt").IsModified = false;
                    entity.Property("createdBy").IsModified = false;
                    ((Base)entity.Entity).updatedAt = DateTime.Now;
                    ((Base)entity.Entity).updatedBy = currentUsername;
                }

            }
        }
        #endregion

    }
}
