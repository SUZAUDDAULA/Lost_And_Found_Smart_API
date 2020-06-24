using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;

namespace LostAndFound.Data.Entity.LostFound
{
    public class ManSpeechDetails:Base
    {
        public int? manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public int? speechId { get; set; }
        public Speech speech { get; set; }
    }
}
