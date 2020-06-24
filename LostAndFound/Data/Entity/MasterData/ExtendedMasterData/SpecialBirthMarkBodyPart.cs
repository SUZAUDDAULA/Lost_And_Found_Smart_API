using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class SpecialBirthMarkBodyPart:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string bodyName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string bodyNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
