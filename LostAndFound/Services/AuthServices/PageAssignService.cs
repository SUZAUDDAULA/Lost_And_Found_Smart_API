using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Sevices.AuthServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthService
{
    public class PageAssignService:IPageAssignService
    {
        private readonly LAFDbContext _context;

        public PageAssignService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveUserAccessPage(UserAccessPage userAccessPage)
        {
            try
            {
                if (userAccessPage.Id != 0)
                {
                    userAccessPage.updatedBy = userAccessPage.createdBy;
                    userAccessPage.updatedAt = DateTime.Now;
                    _context.UserAccessPages.Update(userAccessPage);
                }
                else
                {
                    userAccessPage.createdAt = DateTime.Now;
                    _context.UserAccessPages.Add(userAccessPage);
                }

                await _context.SaveChangesAsync();
                return userAccessPage.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<NavbarViewModel>> GetNavbarDataByUser(string userName, string lang)
        {
            return await _context.navbarViewModels.FromSql($"SP_GetuserMenu {userName},{lang}").ToListAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavbars(string userName)
        {
            return await _context.Navbars.Include(x => x.module).Where(x => x.status == true).OrderBy(x => x.displayOrder).ToListAsync();
        }

        public async Task<IEnumerable<LAFModule>> GetLAFModules()
        {
            return await _context.LAFModules.OrderBy(x => x.shortOrder).ToListAsync();
        }

        public async Task<IEnumerable<UserAccessPageViewModel>> GetUserMenuAccessByUserType(string userRoleId)
        {
            try
            {
                var result = await _context.userAccessPageViewModels.FromSql($"Sp_GetUserMenuAccess {userRoleId}").ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<IEnumerable<UserAccessPageViewModel>> GetUserMenuAccessByUserTypeModule(string userTypeId, string userTypeIdM)
        {
            return await _context.userAccessPageViewModels.FromSql($"Sp_GetUserMenuAccessModule {userTypeId},{userTypeIdM}").ToListAsync();
        }


        public async Task<bool> DeleteUserAccesspageByUserTypeId(string userTypeid)
        {
            _context.UserAccessPages.RemoveRange(_context.UserAccessPages.Where(x => x.applicationRoleId == userTypeid));
            return 1 == await _context.SaveChangesAsync();
        }

    }
}
