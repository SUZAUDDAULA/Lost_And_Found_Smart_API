using LostAndFound.Data.Entity.MasterData;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class GDInformation:Base
    {
        public String ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string gdFor { get; set; }
        public DateTime? gdDate { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string gdNumber { get; set; }
        public int? productTypeId { get; set; }
        public ProductType productType { get; set; }
        public int? gDTypeId { get; set; }// myself or otherperson
        public GDType gDType { get; set; }
        public int? documentTypeId { get; set; }
        public DocumentType documentType { get; set; }
        [Column(TypeName = "NVARCHAR(500)")]
        public string documentDescription { get; set; }
        [Column(TypeName = "NVARCHAR(900)")]
        public string gdDescription { get; set; }
        public int? statusId { get; set; } //1 Complain,2 Investigation,3 finished,4 reject
        [NotMapped]
        public string status { get; set; }
        [NotMapped]
        public string date { get; set; }
    }
}
