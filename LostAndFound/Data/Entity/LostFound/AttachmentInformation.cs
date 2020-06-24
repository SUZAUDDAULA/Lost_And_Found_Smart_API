using LostAndFound.Data.Entity.MasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class AttachmentInformation:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? attachmentTypeId { get; set; }
        public AttachmentType attachmentType { get; set; }
        public int? masterId { get; set; }
        [Column(TypeName = "NVARCHAR(500)")]
        public string fileSubject { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string fileName { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string fileType { get; set; }
        [Column(TypeName = "NVARCHAR(250)")]
        public string filePath { get; set; }
        public byte[] encodedImage { get; set; }
    }
}
