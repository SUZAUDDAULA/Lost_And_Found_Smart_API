using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class AddressSourceType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string sourceName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string sourceNameBn { get; set; }

        public int? shortOrder { get; set; }
    }
}
