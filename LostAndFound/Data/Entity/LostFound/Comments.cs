using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class Comments:Base
    {
        public String ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int? vehicleId { get; set; }
        public VehicleInformation vehicle { get; set; }
        public int? attachmentId { get; set; }
        public AttachmentInformation attachment { get; set; }
        public string comment { get; set; }
        public int? statusId { get; set; }
        [NotMapped]
        public int? total { get; set; }
    }
}
