using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class DocumentCategoryAccessories:Base
    {
        public int? documentTypeId { get; set; }
        public DocumentType documentType { get; set; }
        public int? documentCategoryId { get; set; }
        public DocumentCategory documentCategory { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string accessoriesName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string accessoriesNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
