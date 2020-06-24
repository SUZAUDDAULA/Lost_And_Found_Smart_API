using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class Complextion:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string name { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string nameBn { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string colorCode { get; set; }
        public int? shortOrder { get; set; }
    }
}
