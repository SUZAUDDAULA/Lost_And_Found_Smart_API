using LostAndFound.Data.Entity.MasterData.MDOtherItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData.Interfaces.MDOtherItems
{
    public interface IElectronicService
    {
        #region ElectronicsType
        Task<int> SaveElectronicsType(ElectronicsType electronicsType);
        Task<IEnumerable<ElectronicsType>> GetAllElectronicsType();
        Task<int> DeleteElectronicsTypeById(int id);
        #endregion

        #region FileDocumentType
        Task<int> SaveFileDocumentType(FileDocumentType fileDocumentType);
        Task<IEnumerable<FileDocumentType>> GetAllFileDocumentType();
        Task<int> DeleteFileDocumentTypeById(int id);
        #endregion

        #region MobilePhoneType
        Task<int> SaveMobilePhoneType(MobilePhoneType mobilePhoneType);
        Task<IEnumerable<MobilePhoneType>> GetAllMobilePhoneType();
        Task<int> DeleteMobilePhoneTypeById(int id);
        #endregion

        #region OtherBrand
        Task<int> SaveOtherBrand(OtherBrand otherBrand);
        Task<IEnumerable<OtherBrand>> GetAllOtherBrand(string brandFor);
        Task<int> DeleteOtherBrandById(int id);
        #endregion

        #region Operating System
        Task<int> SaveOperatingSystemType(OperatingSystemType operatingSystemType);
        Task<IEnumerable<OperatingSystemType>> GetAllOperatingSystemType();
        Task<int> DeleteOperatingSystemTypeId(int id);
        #endregion
    }
}
