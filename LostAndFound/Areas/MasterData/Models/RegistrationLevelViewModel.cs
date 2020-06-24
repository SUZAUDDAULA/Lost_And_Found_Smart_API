using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class RegistrationLevelViewModel
    {
        public int? levelId { get; set; }
        public string levelName { get; set; }
        public string levelNameBn { get; set; }
        public int? shortOrder { get; set; }
        public IEnumerable<RegistrationLevel> registrationLevels { get; set; }
    }
}
