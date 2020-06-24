using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData
{
    public class Animal:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string animalName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string animalNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(420)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }
    }
}
