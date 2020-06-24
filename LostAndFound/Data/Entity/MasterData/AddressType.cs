using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Master
{
    public class AddressType : Base
    {
        [Required]
        [Column(TypeName = "NVARCHAR(120)")]
        public string typeName { get; set; }
    }
}
