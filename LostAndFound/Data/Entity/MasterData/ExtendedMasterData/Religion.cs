using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class Religion:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string religionName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string religionNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
