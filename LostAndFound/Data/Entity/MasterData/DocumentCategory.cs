using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class DocumentCategory:Base
    {
        public int? documentTypeId { get; set; }
        public DocumentType documentType { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string categoryName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string categoryNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
