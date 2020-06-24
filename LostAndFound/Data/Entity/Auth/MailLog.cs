using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Auth
{
    public class MailLog:Base
    {
        [Column(TypeName = "nvarchar(200)")]
        public string sender { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string recipient { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string mailType { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string subject { get; set; }

        public DateTime? sendTime { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string refNo { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string notSendReason { get; set; }

        public int? isSuccess { get; set; }
    }
}
