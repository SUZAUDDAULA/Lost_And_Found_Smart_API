using LostAndFound.Data.Entity.LostFound;

namespace LostAndFound.Areas.LostFound.Models
{
    public class GDVehicleDetailsInformationModel
    {
        public GDInformation gDInformation { get; set; }
        public VehicleInformation vehicleInformation { get; set; }
        public OtherPersonInformation otherPersonInformation { get; set; }
        public IndentifyInfo indentifyInfo { get; set; }
        public SpaceAndTime spaceAndTime { get; set; }
    }
}
