namespace LostAndFound.Data.Entity.LostFound
{
    public class DNAProfileDetails:Base
    {
        public int manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public string locous { get; set; }
        public string genotype1 { get; set; }
        public string genotype2 { get; set; }
    }
}
