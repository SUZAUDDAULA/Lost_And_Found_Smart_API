using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LostAndFound.Services.MasterData
{
    public class AddressInformationService : IAddressInformationService
    {
        private readonly LAFDbContext _context;


        public AddressInformationService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAddressInformation(AddressInformation addressInformation)
        {
            if (addressInformation.Id != 0)
            {
                _context.AddressInformation.Update(addressInformation);

                await _context.SaveChangesAsync();

                return 1;
            }

            await _context.AddressInformation.AddAsync(addressInformation);

            await _context.SaveChangesAsync();

            return 1;
        }

        public async Task<IEnumerable<AddressInformation>> GetAllAddressInformation()
        {
            return await _context.AddressInformation.ToListAsync();
        }

        public async Task<AddressInformation> GetAddressInformationById(int id)
        {
            return await _context.AddressInformation.FindAsync(id);
        }

        public async Task<int> DeleteAddressInformationById(int id)
        {
            _context.AddressInformation.Remove(_context.AddressInformation.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
    }
}
