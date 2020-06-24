using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class AttachmentType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string attachmentTypeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string attachmentTypeNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
