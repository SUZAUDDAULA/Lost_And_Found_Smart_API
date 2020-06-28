namespace LostAndFound.Api.Models
{
    public class NewsFeedViewModel
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public string profilePic { get; set; }
        public string gdNumber { get; set; }
        public string vehicleTypeName { get; set; }
        public string gdDate { get; set; }
        public string vehicleDescription { get; set; }
        public string attachImage { get; set; }
        public byte[] encodedImage { get; set; }
        public int? vehicleId { get; set; }
        public int? attachmentId { get; set; }
        public int? totalLikes { get; set; }
        public int? totalComments { get; set; }
    }
}
