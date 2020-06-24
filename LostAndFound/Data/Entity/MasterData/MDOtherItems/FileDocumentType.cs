using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.MDOtherItems
{
    public class FileDocumentType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string typeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string typeNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
