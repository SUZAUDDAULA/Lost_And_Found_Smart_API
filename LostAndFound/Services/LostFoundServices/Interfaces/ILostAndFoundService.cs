using LostAndFound.Api.Models;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Areas.ReportORApplication.Models;
using LostAndFound.Data.Entity.LostFound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.LostFoundServices.Interfaces
{
    public interface ILostAndFoundService
    {
        #region GD Information
        Task<int> SaveGDInformation(GDInformation gDInformation);
        void UpdateGDInformationStatusById(int id, int statusId);
        Task<IEnumerable<GDInformation>> GetAllGDInformation();
        StatusTypeViewModel GetCountGDInformationStatus(string userId);
        GDTypeStatusModel GetCountGDInformationByGDType(string userId, int statusId);
        Task<IEnumerable<GDInformation>> GetAllGDInformationByGDType(int statusId, int gdTypeId);
        Task<IEnumerable<GDInformation>> GetAllGDInformationByStatus(string userId, int statusId);
        Task<IEnumerable<GDInformation>> GetAllGDInformationByFiltering(int statusId, int gdTypeId, string userId);
        Task<IEnumerable<GDInformation>> GetAllGDInformationByUser(string userId);
        Task<GDInformation> GetGDInformationById(int gdId);
        Task<int> DeleteGDInformationById(int id);
        #endregion

        #region Identify Info
        Task<int> SaveIndentifyInfo(IndentifyInfo indentifyInfo);
        Task<IndentifyInfo> GetIndentifyInfoByGDId(int gdId);
        Task<int> DeleteIndentifyInfoByGDId(int gdId);
        #endregion

        #region Man Habit Details
        Task<int> SaveManHabitDetails(ManHabitDetails manHabitDetails);

        Task<IEnumerable<ManHabitDetails>> GetManHabitDetailsByManId(int manId);

        #endregion

        #region Man Speech Details
        Task<int> SaveManSpeechDetails(ManSpeechDetails manSpeechDetails);
        Task<IEnumerable<ManSpeechDetails>> GetManSpeechDetailsByManId(int manId);

        #endregion

        #region Man DNA Profile
        Task<int> SaveDNAProfileDetails(List<DNAProfileDetails> dNAProfileDetails);
        Task<IEnumerable<DNAProfileDetails>> GetDNAProfileDetailsByManId(int manId);

        #endregion

        #region Other Person Information
        Task<int> SaveOtherPersonInformation(OtherPersonInformation otherPersonInformation);
        Task<OtherPersonInformation> GetOtherPersonInformationByGDId(int gdId);
        Task<int> DeleteOtherPersonInformationByGDId(int gdId);
        #endregion

        #region Space And Time Info
        Task<int> SaveSpaceAndTime(SpaceAndTime spaceAndTime);
        Task<SpaceAndTime> GetSpaceAndTimeByGDId(int gdId);
        Task<int> DeleteSpaceAndTimeByGDId(int gdId);
        #endregion

        #region Vehicle Information
        Task<int> SaveVehicleInformation(VehicleInformation vehicleInformation);
        Task<VehicleInformation> GetVehicleInformationByGDId(int gdId);
        Task<IEnumerable<string>> GetAllVehicleModelNo();
        Task<IEnumerable<VehicleInformation>> GetVehicleInformationBySearching(int? typeId, int? brandId, string modelNo, string regiNo, string engineNo, string chesisNo, string cc, int? colorId, string userId);
        Task<int> DeleteVehicleInformationByGDId(int gdId);
        Task<IEnumerable<NewsFeedViewModel>> GetALLNewFeedsInfo(string userId, int vehicleTypeId);
        #endregion

        #region Man Information
        Task<int> SaveManInformation(ManInformation manInformation);
        Task<ManInformation> GetManInformationByGDId(int gdId);
        Task<IEnumerable<GDInformation>> GetMenInformationBySearching(GDManInformationViewModel model);
        Task<int> DeleteManInformationByGDId(int gdId);

        #endregion

        #region Physical Information
        Task<int> SavePhysicalDescription(PhysicalDescription physicalDescription);

        #endregion

        #region Dress Information
        Task<int> SaveDressDescription(DressDescription dressDescription);
        #endregion

        #region Attachment Information
        Task<int> SaveAttachmentInformation(AttachmentInformation attachment);
        #endregion

        #region Likes
        Task<int> SaveLikes(Likes likes);
        Task<IEnumerable<Likes>> GetAllLikes();
        Task<Likes> GetLikesById(int id);
        Task<int> DeleteLikesById(int id);
        #endregion

        #region Comments
        Task<int> SaveComments(Comments comments);
        #endregion

    }
}
