using LostAndFound.Data.Entity.Master;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface IAddressService
    {
        #region Division

        Task<bool> SaveCountry(Country country);
        Task<IEnumerable<Country>> GetAllContry();
        Task<Country> GetContryById(int id);
        Task<bool> DeleteContryById(int id);
      
        #endregion

        #region Division

        Task<bool> SaveDivision(Division division);
        Task<IEnumerable<Division>> GetAllDivision();
        Task<Division> GetDivisionById(int id);
        Task<bool> DeleteDivisionById(int id);
        Task<IEnumerable<Division>> GetDivisionsByCountryId(int CntId);

        #endregion

        #region District

        Task<bool> SaveDistrict(District district);
        Task<IEnumerable<District>> GetAllDistrict();
        Task<District> GetDistrictById(int id);
        Task<bool> DeleteDistrictById(int id);
        Task<IEnumerable<District>> GetDistrictsByDivisonId(int DivisionId);

        #endregion

        #region Thana

        Task<bool> SaveThana(Thana thana);
        Task<IEnumerable<Thana>> GetAllThana();
        Task<Thana> GetThanaById(int id);
        Task<bool> DeleteThanaById(int id);
        Task<IEnumerable<Thana>> GetThanasByDistrictId(int DistrictId);

        #endregion

        #region Post Office

        Task<bool> SavePostOffice(PostOffice postOffice);
        Task<IEnumerable<PostOffice>> GetAllPostOffice();
        Task<PostOffice> GetPostOfficeById(int id);
        Task<bool> DeletePostOfficeById(int id);
        Task<IEnumerable<PostOffice>> GetPostOfficeByDistrictId(int DistrictId);

        #endregion

        

    }
}
