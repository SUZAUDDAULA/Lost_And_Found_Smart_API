using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class Gender:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string genderName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string genderNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
