using LostAndFound.Data.Entity.LostFound;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Services.LostFoundServices.Interfaces
{
    public interface IOtherDocumentService
    {
        Task<int> SaveOtherDocumentDetail(OtherDocumentDetail otherDocumentDetail);
        Task<OtherDocumentDetail> GetOtherDocumentDetailById(int id);
        Task<IEnumerable<OtherDocumentDetail>> GetOtherDocumentDetailByDocumentId(int documentId);
        Task<int> DeleteOtherDocumentDetailById(int id);
    }
}
