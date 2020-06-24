using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class DocumentType:Base
    {
        [Column(TypeName = "NVARCHAR(100)")]
        public string documentFor { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string documentTypeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string documentTypeNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
