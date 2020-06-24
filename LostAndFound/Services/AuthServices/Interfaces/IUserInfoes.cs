using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.Auth;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Sevices.AuthServices.Interfaces
{
    public interface IUserInfoes
    {
        Task<IEnumerable<UserType>> GetUserTypeList();
        Task<ApplicationUser> GetUserBasicInfoes(string userName);
        //Task<int> GetMaxUserId();

        #region

        Task<int> SaveRole(RolesViewModel  rolesViewModel);
        Task<IEnumerable<IdentityRole>> GetAllRoles();
        //Task<IdentityRole> GetRoleById();
        //Task<int> DeleteRole();

        #endregion
    }
}
