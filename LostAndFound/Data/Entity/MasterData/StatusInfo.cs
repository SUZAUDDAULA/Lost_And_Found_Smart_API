using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class StatusInfo:Base
    {
        [Column(TypeName = "NVARCHAR(100)")]
        public string statusName { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string statusNameBn { get; set; }
        public int? shortOrder { get; set; }
    }
}
