using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;

namespace LostAndFound.Data.Entity.LostFound
{
    public class ManHabitDetails:Base
    {
        public int? manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public int? habitId { get; set; }
        public Habit habit { get; set; }
    }
}
