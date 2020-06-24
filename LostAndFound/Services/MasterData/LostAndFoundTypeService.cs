using LostAndFound.Data;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData
{
    public class LostAndFoundTypeService: ILostAndFoundType
    {
        private readonly LAFDbContext _context;

        public LostAndFoundTypeService(LAFDbContext context)
        {
            _context = context;
        }
        #region Lost And Found Type

        public async Task<int> SaveLostAndFoundType(LostAndFoundType lostAndFoundType)
        {
            if (lostAndFoundType.Id != 0)
            {
                _context.LostAndFoundTypes.Update(lostAndFoundType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.LostAndFoundTypes.AddAsync(lostAndFoundType);

                await _context.SaveChangesAsync();

                return 1;
            }
            
        }

        public async Task<IEnumerable<LostAndFoundType>> GetLostAndFoundType()
        {
            return await _context.LostAndFoundTypes.ToListAsync();
        }


        public async Task<int> DeleteLostAndFoundTypeById(int id)
        {
            _context.LostAndFoundTypes.Remove(_context.LostAndFoundTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region GD Type
        public async Task<int> SaveGDType(GDType gDType)
        {
            if (gDType.Id != 0)
            {
                _context.GDTypes.Update(gDType);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.GDTypes.AddAsync(gDType);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<GDType>> GetGDTypes()
        {
            return await _context.GDTypes.ToListAsync();
        }
        public async Task<GDType> GetGDTypesById(int id)
        {
            return await _context.GDTypes.FindAsync(id);
        }
        public async Task<int> DeleteGDTypeById(int id)
        {
            _context.GDTypes.Remove(_context.GDTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion 

        #region Document Type
        public async Task<int> SaveDocumentType(DocumentType documentType)
        {
            if (documentType.Id != 0)
            {
                _context.DocumentTypes.Update(documentType);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.DocumentTypes.AddAsync(documentType);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<DocumentType>> GetDocumentTypes()
        {
            return await _context.DocumentTypes.OrderBy(x=>x.shortOrder).ToListAsync();
        }
        public async Task<DocumentType> GetDocumentTypesById(int id)
        {
            return await _context.DocumentTypes.FindAsync(id);
        }
        public async Task<int> DeleteDocumentTypeById(int id)
        {
            _context.DocumentTypes.Remove(_context.DocumentTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Document Category
        public async Task<int> SaveDocumentCategory(DocumentCategory documentCategory)
        {
            if (documentCategory.Id != 0)
            {
                _context.DocumentCategories.Update(documentCategory);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.DocumentCategories.AddAsync(documentCategory);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<DocumentCategory>> GetDocumentCategory()
        {
            return await _context.DocumentCategories.ToListAsync();
        }
        public async Task<IEnumerable<DocumentCategory>> GetDocumentCategoryByTypeId(int id)
        {
            return await _context.DocumentCategories.Where(x=>x.documentTypeId==id).ToListAsync();
        }
        public async Task<int> DeleteGetDocumentCategoryById(int id)
        {
            _context.DocumentCategories.Remove(_context.DocumentCategories.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Document Category Brand
        public async Task<int> SaveDocumentCategoryBrand(DocumentCategoryBrand documentCategoryBrand)
        {
            if (documentCategoryBrand.Id != 0)
            {
                _context.DocumentCategoryBrands.Update(documentCategoryBrand);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.DocumentCategoryBrands.AddAsync(documentCategoryBrand);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<DocumentCategoryBrand>> GetDocumentCategoryBrandByDocumentTypeId(int documentTypeId)
        {
            return await _context.DocumentCategoryBrands.Where(x=>x.documentTypeId==documentTypeId).ToListAsync();
        }
        public async Task<IEnumerable<DocumentCategoryBrand>> GetDocumentCategoryBrandByCategoryId(int categoryId)
        {
            return await _context.DocumentCategoryBrands.Where(x => x.documentCategoryId == categoryId).ToListAsync();
        }
        public async Task<int> DeleteDocumentCategoryBrandById(int id)
        {
            _context.DocumentCategoryBrands.Remove(_context.DocumentCategoryBrands.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Document Category Accessories
        public async Task<int> SaveDocumentCategoryAccessories(DocumentCategoryAccessories documentCategoryAccessories)
        {
            if (documentCategoryAccessories.Id != 0)
            {
                _context.DocumentCategoryAccessories.Update(documentCategoryAccessories);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.DocumentCategoryAccessories.AddAsync(documentCategoryAccessories);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<DocumentCategoryAccessories>> GetDocumentCategoryAccessoriesByDocumentTypeId(int documentTypeId)
        {
            return await _context.DocumentCategoryAccessories.Where(x => x.documentTypeId == documentTypeId).ToListAsync();
        }
        public async Task<IEnumerable<DocumentCategoryAccessories>> GetDocumentCategoryAccessoriesByCategoryId(int categoryId)
        {
            return await _context.DocumentCategoryAccessories.Where(x => x.documentCategoryId == categoryId).ToListAsync();
        }
        public async Task<int> DeleteDocumentCategoryDocumentCategoryAccessoriesById(int id)
        {
            _context.DocumentCategoryAccessories.Remove(_context.DocumentCategoryAccessories.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Computer Accessories Brand
        public async Task<int> SaveComputerAccessoriesBrand(ComputerAccessoriesBrand computerAccessoriesBrand)
        {
            if (computerAccessoriesBrand.Id != 0)
            {
                _context.ComputerAccessoriesBrands.Update(computerAccessoriesBrand);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.ComputerAccessoriesBrands.AddAsync(computerAccessoriesBrand);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<ComputerAccessoriesBrand>> GetAllComputerAccessoriesBrand()
        {
            return await _context.ComputerAccessoriesBrands.ToListAsync();
        }
        
        public async Task<int> DeleteComputerAccessoriesBrandById(int id)
        {
            _context.ComputerAccessoriesBrands.Remove(_context.ComputerAccessoriesBrands.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region NationalIdentity Type
        public async Task<int> SaveNationalIdentityType(NationalIdentityType nationalIdentityType)
        {
            if (nationalIdentityType.Id != 0)
            {
                _context.NationalIdentityTypes.Update(nationalIdentityType);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.NationalIdentityTypes.AddAsync(nationalIdentityType);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<NationalIdentityType>> GetNationalIdentityTypes()
        {
            return await _context.NationalIdentityTypes.ToListAsync();
        }

        public async Task<int> DeleteNatinoalIdentityTypeById(int id)
        {
            _context.NationalIdentityTypes.Remove(_context.NationalIdentityTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region VehicleType
        public async Task<int> SaveVehicleType(VehicleType vehicleType)
        {
            if (vehicleType.Id != 0)
            {
                _context.VehicleTypes.Update(vehicleType);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.VehicleTypes.AddAsync(vehicleType);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<VehicleType>> GetVehicleTypes()
        {

            var result= await _context.VehicleTypes.ToListAsync();
            return result;
        }
        public async Task<int> DeleteVehicleTypeById(int id)
        {
            _context.VehicleTypes.Remove(_context.VehicleTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Vehicle Model
        public async Task<int> SaveVehicleModel(VehicleModel vehicleModel)
        {
            if (vehicleModel.Id != 0)
            {
                _context.VehicleModels.Update(vehicleModel);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.VehicleModels.AddAsync(vehicleModel);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<VehicleModel>> GetVehicleModel()
        {
            return await _context.VehicleModels.Include(x=>x.vehicleType).ToListAsync();
        }

        public async Task<IEnumerable<VehicleModel>> GetVehicleModelByVehicleId(int id)
        {
            return await _context.VehicleModels.Where(x=>x.vehicleTypeId==id).ToListAsync();
        }

        public async Task<int> DeleteVehicleModelById(int id)
        {
            _context.VehicleModels.Remove(_context.VehicleModels.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Metropolitan Area
        public async Task<int> SaveMetropolitanArea(MetropolitanArea metropolitan)
        {
            if (metropolitan.Id != 0)
            {
                _context.MetropolitanAreas.Update(metropolitan);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.MetropolitanAreas.AddAsync(metropolitan);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<MetropolitanArea>> GetMetropolitanArea()
        {
            return await _context.MetropolitanAreas.ToListAsync();
        }

        public async Task<int> DeleteMetropolitanAreaById(int id)
        {
            _context.MetropolitanAreas.Remove(_context.MetropolitanAreas.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Registration Area
        public async Task<int> SaveRegistrationLevel(RegistrationLevel registrationLevel)
        {
            if (registrationLevel.Id != 0)
            {
                _context.RegistrationLevels.Update(registrationLevel);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.RegistrationLevels.AddAsync(registrationLevel);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<RegistrationLevel>> GetRegistrationLevel()
        {
            return await _context.RegistrationLevels.ToListAsync();
        }

        public async Task<int> DeleteRegistrationLevelById(int id)
        {
            _context.RegistrationLevels.Remove(_context.RegistrationLevels.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Animal
        public async Task<int> SaveAnimal(Animal animal)
        {
            if (animal.Id != 0)
            {
                _context.Animals.Update(animal);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.Animals.AddAsync(animal);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<Animal>> GetAnimals()
        {
            return await _context.Animals.ToListAsync();
        }

        public async Task<int> DeleteAnimalById(int id)
        {
            _context.Animals.Remove(_context.Animals.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Color
        public async Task<int> SaveColors(Colors colors)
        {
            if (colors.Id != 0)
            {
                _context.Colors.Update(colors);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.Colors.AddAsync(colors);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<Colors>> GetColors()
        {
            return await _context.Colors.ToListAsync();
        }
        public async Task<int> DeleteColorById(int id)
        {
            _context.Colors.Remove(_context.Colors.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Man Body Part
        public async Task<int> SaveManBodyPart(ManBodyPart manBodyPart)
        {
            if (manBodyPart.Id != 0)
            {
                _context.ManBodyParts.Update(manBodyPart);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.ManBodyParts.AddAsync(manBodyPart);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<ManBodyPart>> GetManBodyPart()
        {
            return await _context.ManBodyParts.ToListAsync();
        }

        public async Task<int> DeleteManBodyPartById(int id)
        {
            _context.ManBodyParts.Remove(_context.ManBodyParts.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region ProductType
        public async Task<int> SaveProductType(ProductType productType)
        {
            if (productType.Id != 0)
            {
                _context.ProductTypes.Update(productType);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.ProductTypes.AddAsync(productType);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<ProductType>> GetProductType()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<int> DeleteProductTypeById(int id)
        {
            _context.ProductTypes.Remove(_context.ProductTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Occupation
        public async Task<int> SaveOccupation(Occupation occupation)
        {
            if (occupation.Id != 0)
            {
                _context.Occupations.Update(occupation);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.Occupations.AddAsync(occupation);
                await _context.SaveChangesAsync();
                return 1;
            }
        }

        public async Task<IEnumerable<Occupation>> GetOccupation()
        {
            return await _context.Occupations.ToListAsync();
        }

        public async Task<int> DeleteOccupationById(int id)
        {
            _context.Occupations.Remove(_context.Occupations.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Genders
        public async Task<int> SaveGender(Gender gender)
        {
            if (gender.Id != 0)
            {
                _context.Genders.Update(gender);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.Genders.AddAsync(gender);
                await _context.SaveChangesAsync();
                return 1;
            }
        }

        public async Task<IEnumerable<Gender>> GetAllGender()
        {
            return await _context.Genders.ToListAsync();
        }

        public async Task<int> DeleteGenderById(int id)
        {
            _context.Genders.Remove(_context.Genders.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

    }
}
