using LostAndFound.Data;
using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using LostAndFound.Services.MasterData.Interfaces.MDOtherItems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData.MDOtherItems
{
    public class ElectronicService : IElectronicService
    {

        private readonly LAFDbContext _context;

        public ElectronicService(LAFDbContext context)
        {
            _context = context;
        }

        #region ElectronicsType
        public async Task<int> SaveElectronicsType(ElectronicsType electronicsType)
        {
            if (electronicsType.Id != 0)
            {
                _context.ElectronicsTypes.Update(electronicsType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.ElectronicsTypes.AddAsync(electronicsType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<ElectronicsType>> GetAllElectronicsType()
        {
            return await _context.ElectronicsTypes.ToListAsync();
        }
        public async Task<int> DeleteElectronicsTypeById(int id)
        {
            _context.ElectronicsTypes.Remove(_context.ElectronicsTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region FileDocumentType
        public async Task<int> SaveFileDocumentType(FileDocumentType fileDocumentType)
        {
            if (fileDocumentType.Id != 0)
            {
                _context.FileDocumentTypes.Update(fileDocumentType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.FileDocumentTypes.AddAsync(fileDocumentType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<FileDocumentType>> GetAllFileDocumentType()
        {
            return await _context.FileDocumentTypes.ToListAsync();
        }
        public async Task<int> DeleteFileDocumentTypeById(int id)
        {
            _context.FileDocumentTypes.Remove(_context.FileDocumentTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MobilePhoneType
        public async Task<int> SaveMobilePhoneType(MobilePhoneType mobilePhoneType)
        {
            if (mobilePhoneType.Id != 0)
            {
                _context.MobilePhoneTypes.Update(mobilePhoneType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MobilePhoneTypes.AddAsync(mobilePhoneType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<MobilePhoneType>> GetAllMobilePhoneType()
        {
            return await _context.MobilePhoneTypes.ToListAsync();
        }
        public async Task<int> DeleteMobilePhoneTypeById(int id)
        {
            _context.MobilePhoneTypes.Remove(_context.MobilePhoneTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Other Brand
        public async Task<int> SaveOtherBrand(OtherBrand otherBrand)
        {
            if (otherBrand.Id != 0)
            {
                _context.OtherBrands.Update(otherBrand);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.OtherBrands.AddAsync(otherBrand);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<OtherBrand>> GetAllOtherBrand(string brandFor)
        {
            return await _context.OtherBrands.Where(x=>x.brandFor==brandFor).ToListAsync();
        }
        public async Task<int> DeleteOtherBrandById(int id)
        {
            
            _context.OtherBrands.Remove(_context.OtherBrands.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Operating System Type
        public async Task<int> SaveOperatingSystemType(OperatingSystemType operatingSystemType)
        {
            if (operatingSystemType.Id != 0)
            {
                _context.OperatingSystemTypes.Update(operatingSystemType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.OperatingSystemTypes.AddAsync(operatingSystemType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<OperatingSystemType>> GetAllOperatingSystemType()
        {
            return await _context.OperatingSystemTypes.ToListAsync();
        }
        public async Task<int> DeleteOperatingSystemTypeId(int id)
        {

            _context.OperatingSystemTypes.Remove(_context.OperatingSystemTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

    }
}
