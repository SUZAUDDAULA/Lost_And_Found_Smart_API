using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;

namespace LostAndFound.Areas.MasterData.Models
{
    public class AttachmentTypeViewModel
    {
        public string attachmentTypeName { get; set; }
        public string attachmentTypeNameBn { get; set; }
        public int? shortOrder { get; set; }

        public IEnumerable<AttachmentType> AttachmentTypes { get; set; }


    }
}
