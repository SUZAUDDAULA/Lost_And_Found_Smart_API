using LostAndFound.Data.Entity.LostFound;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Api.Models
{
    public class LikesViewModel
    {
        public String ApplicationUserId { get; set; }
        public int? vehicleId { get; set; }
        public int? attachmentId { get; set; }
        public int? statusId { get; set; }
        [NotMapped]
        public int? total { get; set; }


        public IEnumerable<Likes> Likes { get; set; }
    }
}
