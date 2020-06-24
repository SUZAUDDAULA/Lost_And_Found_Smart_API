using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class ManBodyPart:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string partName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string partNameBN { get; set; }
        public int? shortOrder { get; set; }
    }
}
