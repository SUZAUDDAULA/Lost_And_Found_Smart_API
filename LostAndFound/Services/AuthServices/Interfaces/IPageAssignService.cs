using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data.Entity.Auth;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Sevices.AuthServices.Interfaces
{
    public interface IPageAssignService
    {
        Task<int> SaveUserAccessPage(UserAccessPage userAccessPage);

        Task<IEnumerable<NavbarViewModel>> GetNavbarDataByUser(string userName, string lang);

        Task<IEnumerable<UserAccessPageViewModel>> GetUserMenuAccessByUserType(string userRoleId);

        Task<bool> DeleteUserAccesspageByUserTypeId(string userTypeId);
        Task<IEnumerable<Navbar>> GetNavbars(string userName);
        Task<IEnumerable<LAFModule>> GetLAFModules();
        Task<IEnumerable<UserAccessPageViewModel>> GetUserMenuAccessByUserTypeModule(string userTypeId, string userTypeIdM);

    }
}
