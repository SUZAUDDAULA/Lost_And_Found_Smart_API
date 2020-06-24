using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data.Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthServices.Interfaces
{
    public interface IModuleAssignService
    {
        Task<int> SaveModuleAccessPage(ModuleAccessPage userAccessPage);
        Task<IEnumerable<ModuleAccessPage>> GetModuleAccessPages();
        Task<IEnumerable<LAFModule>> GetLAFModules();
        Task<bool> DeleteModuleAccesspageByUserTypeId(string userTypeid);
        Task<IEnumerable<ModuleAccessPageViewModel>> GetModuleAccessPagesactive(string userRoleId);
    }
}
