using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;

namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface IAddressCategoryService
    {
        Task<int> SaveAddressCategory(AddressCategory addressCategory);
        Task<IEnumerable<AddressCategory>> GetAllAddressCategory();
        Task<AddressCategory> GetAddressCategoryById(int id);
        Task<int> DeleteAddressCategoryById(int id);
    }
}
