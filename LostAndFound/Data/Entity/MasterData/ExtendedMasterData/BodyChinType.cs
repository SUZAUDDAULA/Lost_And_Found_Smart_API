using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class BodyChinType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string chinTypeName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string chinTypeNameBn { get; set; }

        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }

        public int? shortOrder { get; set; }
    }
}
