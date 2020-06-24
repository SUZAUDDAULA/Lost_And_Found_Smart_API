using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class RegistrationLevel:Base
    {
        [Column(TypeName = "NVARCHAR(50)")]
        public string levelName { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string levelNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
