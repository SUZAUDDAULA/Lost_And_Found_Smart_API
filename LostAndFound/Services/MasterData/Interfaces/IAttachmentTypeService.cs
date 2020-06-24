using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;

namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface IAttachmentTypeService
    {
        Task<int> SaveAttachmentType(AttachmentType attachmentType);
        Task<IEnumerable<AttachmentType>> GetAllAttachmentType();
        Task<AttachmentType> GetAttachmentTypeById(int id);
        Task<int> DeleteAttachmentTypeById(int id);
    }
}
