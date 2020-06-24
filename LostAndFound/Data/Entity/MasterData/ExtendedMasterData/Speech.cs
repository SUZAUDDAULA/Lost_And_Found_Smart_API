using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class Speech:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string speechName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string speechNameBn { get; set; }

        public int? shortOrder { get; set; }
    }
}
