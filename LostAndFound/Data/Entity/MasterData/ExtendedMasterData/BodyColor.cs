using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class BodyColor:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string colorName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string colorNameBn { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string colorCode { get; set; }

        public int? shortOrder { get; set; }
    }
}
