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
    public class AddressCategoryService : IAddressCategoryService
    {
        private readonly LAFDbContext _context;


        public AddressCategoryService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAddressCategory(AddressCategory addressCategory)
        {
            if (addressCategory.Id != 0)
            {
                _context.AddressCategories.Update(addressCategory);

                await _context.SaveChangesAsync();

                return 1;
            }

            await _context.AddressCategories.AddAsync(addressCategory);

            await _context.SaveChangesAsync();

            return 1;
        }

        public async Task<IEnumerable<AddressCategory>> GetAllAddressCategory()
        {
            return await _context.AddressCategories.ToListAsync();
        }

        public async Task<AddressCategory> GetAddressCategoryById(int id)
        {
            return await _context.AddressCategories.FindAsync(id);
        }

        public async Task<int> DeleteAddressCategoryById(int id)
        {
            _context.AddressCategories.Remove(_context.AddressCategories.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
    }
}
