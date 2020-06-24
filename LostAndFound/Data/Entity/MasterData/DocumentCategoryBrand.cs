using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class DocumentCategoryBrand:Base
    {
        public int? documentTypeId { get; set; }
        public DocumentType documentType { get; set; }
        public int? documentCategoryId { get; set; }
        public DocumentCategory documentCategory { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string brandNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
