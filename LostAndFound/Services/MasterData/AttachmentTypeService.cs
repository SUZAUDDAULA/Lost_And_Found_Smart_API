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
    public class AttachmentTypeService : IAttachmentTypeService
    {
        private readonly LAFDbContext _context;


        public AttachmentTypeService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAttachmentType(AttachmentType attachmentType)
        {
            if (attachmentType.Id != 0)
            {
                _context.AttachmentTypes.Update(attachmentType);

                await _context.SaveChangesAsync();

                return 1;
            }

            await _context.AttachmentTypes.AddAsync(attachmentType);

            await _context.SaveChangesAsync();

            return 1;
        }

        public async Task<IEnumerable<AttachmentType>> GetAllAttachmentType()
        {
            return await _context.AttachmentTypes.ToListAsync();
        }

        public async Task<AttachmentType> GetAttachmentTypeById(int id)
        {
            return await _context.AttachmentTypes.FindAsync(id);
        }

        public async Task<int> DeleteAttachmentTypeById(int id)
        {
            _context.AttachmentTypes.Remove(_context.AttachmentTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
    }
}
