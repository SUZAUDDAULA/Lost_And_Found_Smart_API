using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;

namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface IAddressInformationService
    {
        Task<int> SaveAddressInformation(AddressInformation addressInformation);
        Task<IEnumerable<AddressInformation>> GetAllAddressInformation();
        Task<AddressInformation> GetAddressInformationById(int id);
        Task<int> DeleteAddressInformationById(int id);
    }
}
