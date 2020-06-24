using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class AddressCategory : Base
    {
        [Column(TypeName = "NVARCHAR(120)")]
        public string name { get; set; }
    }
}
