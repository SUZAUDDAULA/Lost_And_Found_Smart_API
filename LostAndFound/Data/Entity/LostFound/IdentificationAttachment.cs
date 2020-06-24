using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class IdentificationAttachment:Base
    {
        public int? indentifyId { get; set; }
        public IndentifyInfo indentify { get; set; }
        public int? masterId { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string fileName { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string fileType { get; set; }
        [Column(TypeName = "NVARCHAR(250)")]
        public string filePath { get; set; }
    }
}
