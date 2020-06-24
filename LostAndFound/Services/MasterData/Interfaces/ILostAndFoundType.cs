using LostAndFound.Data.Entity.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface ILostAndFoundType
    {
        #region Lost And Found Type
        Task<int> SaveLostAndFoundType(LostAndFoundType lostAndFoundType);
        Task<IEnumerable<LostAndFoundType>> GetLostAndFoundType();
        Task<int> DeleteLostAndFoundTypeById(int id);
        #endregion

        #region GD Type
        Task<int> SaveGDType(GDType gDType);
        Task<IEnumerable<GDType>> GetGDTypes();
        Task<GDType> GetGDTypesById(int id);
        Task<int> DeleteGDTypeById(int id);
        #endregion

        #region Document Type
        Task<int> SaveDocumentType(DocumentType documentType);
        Task<IEnumerable<DocumentType>> GetDocumentTypes();
        Task<DocumentType> GetDocumentTypesById(int id);
        Task<int> DeleteDocumentTypeById(int id);
        #endregion

        #region Document Category
        Task<int> SaveDocumentCategory(DocumentCategory documentCategory);
        Task<IEnumerable<DocumentCategory>> GetDocumentCategory();
        Task<IEnumerable<DocumentCategory>> GetDocumentCategoryByTypeId(int id);
        Task<int> DeleteGetDocumentCategoryById(int id);
        #endregion

        #region Document Category Brand
        Task<int> SaveDocumentCategoryBrand(DocumentCategoryBrand documentCategoryBrand);
        Task<IEnumerable<DocumentCategoryBrand>> GetDocumentCategoryBrandByDocumentTypeId(int documentTypeId);
        Task<IEnumerable<DocumentCategoryBrand>> GetDocumentCategoryBrandByCategoryId(int categoryId);
        Task<int> DeleteDocumentCategoryBrandById(int id);
        #endregion

        #region Computer Accessories Brand
        Task<int> SaveComputerAccessoriesBrand(ComputerAccessoriesBrand computerAccessoriesBrand);
        Task<IEnumerable<ComputerAccessoriesBrand>> GetAllComputerAccessoriesBrand();
        Task<int> DeleteComputerAccessoriesBrandById(int id);
        #endregion

        #region Document Category Accessories
        Task<int> SaveDocumentCategoryAccessories(DocumentCategoryAccessories documentCategoryAccessories);
        Task<IEnumerable<DocumentCategoryAccessories>> GetDocumentCategoryAccessoriesByDocumentTypeId(int documentTypeId);
        Task<IEnumerable<DocumentCategoryAccessories>> GetDocumentCategoryAccessoriesByCategoryId(int categoryId);
        Task<int> DeleteDocumentCategoryDocumentCategoryAccessoriesById(int id);
        #endregion

        #region NationalIdentity Type
        Task<int> SaveNationalIdentityType(NationalIdentityType nationalIdentityType);
        Task<IEnumerable<NationalIdentityType>> GetNationalIdentityTypes();
        Task<int> DeleteNatinoalIdentityTypeById(int id);
        #endregion

        #region VehicleType
        Task<int> SaveVehicleType(VehicleType vehicleType);
        Task<IEnumerable<VehicleType>> GetVehicleTypes();
        Task<int> DeleteVehicleTypeById(int id);
        #endregion

        #region Vehicle Model
        Task<int> SaveVehicleModel(VehicleModel vehicleModel);
        Task<IEnumerable<VehicleModel>> GetVehicleModel();
        Task<IEnumerable<VehicleModel>> GetVehicleModelByVehicleId(int id);
        Task<int> DeleteVehicleModelById(int id);
        #endregion

        #region Metropolitan Area
        Task<int> SaveMetropolitanArea(MetropolitanArea metropolitanArea);
        Task<IEnumerable<MetropolitanArea>> GetMetropolitanArea();
        Task<int> DeleteMetropolitanAreaById(int id);
        #endregion

        #region Registration Level
        Task<int> SaveRegistrationLevel(RegistrationLevel registrationLevel);
        Task<IEnumerable<RegistrationLevel>> GetRegistrationLevel();
        Task<int> DeleteRegistrationLevelById(int id);
        #endregion

        #region Animal
        Task<int> SaveAnimal(Animal animal);
        Task<IEnumerable<Animal>> GetAnimals();
        Task<int> DeleteAnimalById(int id);
        #endregion

        #region Color
        Task<int> SaveColors(Colors colors);
        Task<IEnumerable<Colors>> GetColors();
        Task<int> DeleteColorById(int id);
        #endregion

        #region Man Body Part
        Task<int> SaveManBodyPart(ManBodyPart manBodyPart);
        Task<IEnumerable<ManBodyPart>> GetManBodyPart();
        Task<int> DeleteManBodyPartById(int id);
        #endregion

        #region ProductType
        Task<int> SaveProductType(ProductType productType);
        Task<IEnumerable<ProductType>> GetProductType();
        Task<int> DeleteProductTypeById(int id);
        #endregion

        #region Occupation
        Task<int> SaveOccupation(Occupation occupation);
        Task<IEnumerable<Occupation>> GetOccupation();
        Task<int> DeleteOccupationById(int id);
        #endregion

        #region Genders
        Task<int> SaveGender(Gender gender);        
        Task<IEnumerable<Gender>> GetAllGender();
        Task<int> DeleteGenderById(int id);
        
        #endregion

    }
}
