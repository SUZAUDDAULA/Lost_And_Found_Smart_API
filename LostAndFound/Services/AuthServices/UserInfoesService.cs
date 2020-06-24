using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Sevices.AuthServices.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthServices
{
    public class UserInfoesService : IUserInfoes
    {
        private readonly LAFDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserInfoesService(LAFDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.roleManager = roleManager;
        }

        public async Task<IEnumerable<UserType>> GetUserTypeList()
        {
            return await _context.UserTypes.AsNoTracking().AsNoTracking().ToListAsync();
        }

        public async Task<ApplicationUser> GetUserBasicInfoes(string userName)
        {
            return await _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
        }
        
        //public async Task<int> GetMaxUserId()
        //{
        //    var result = await _context.Users.MaxAsync(x => x.userId);
        //    return result;
        //}

        public async Task<int> SaveRole(RolesViewModel model)
        {

            IdentityRole role = new IdentityRole();

            role.Name = model.name;

            await roleManager.CreateAsync(role);

            return 1;
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRoles()
        {
            var data = await roleManager.Roles.ToListAsync();

            return data;
        }

       
    }
}
