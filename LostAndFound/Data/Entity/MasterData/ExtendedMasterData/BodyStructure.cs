using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class BodyStructure:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string structureName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string structureNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
