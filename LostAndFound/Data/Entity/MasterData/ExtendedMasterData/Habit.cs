using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.ExtendedMasterData
{
    public class Habit:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string habitName { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string habitNameBn { get; set; }

        public int? shortOrder { get; set; }
    }
}
