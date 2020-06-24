using LostAndFound.Data;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Services.LostFoundServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.LostFoundServices
{
    public class OtherDocumentService : IOtherDocumentService
    {
        private readonly LAFDbContext _context;

        public OtherDocumentService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveOtherDocumentDetail(OtherDocumentDetail otherDocumentDetail)
        {
            if (otherDocumentDetail.Id != 0)
            {
                _context.OtherDocumentDetails.Update(otherDocumentDetail);

                await _context.SaveChangesAsync();

                return otherDocumentDetail.Id;
            }
            else
            {
                await _context.OtherDocumentDetails.AddAsync(otherDocumentDetail);

                await _context.SaveChangesAsync();

                return otherDocumentDetail.Id;
            }
        }

        public async Task<OtherDocumentDetail> GetOtherDocumentDetailById(int id)
        {
            return await _context.OtherDocumentDetails
                .Include(x => x.gDInformation)
                .Include(x => x.documentType)
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<OtherDocumentDetail>> GetOtherDocumentDetailByDocumentId(int documentId)
        {
            return await _context.OtherDocumentDetails
               .Include(x => x.gDInformation)
               .Include(x => x.documentType)
               .Where(x => x.documentTypeId == documentId).ToListAsync();
        }

        
        public async Task<int> DeleteOtherDocumentDetailById(int id)
        {
            _context.OtherDocumentDetails.Remove(_context.OtherDocumentDetails.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

    }
}
