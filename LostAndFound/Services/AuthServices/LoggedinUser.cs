using LostAndFound.Data;
using LostAndFound.Data.Entity;
using LostAndFound.Services.Auth.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.Auth
{
    public class LoggedinUser : ILoggedinUser
    {
        private readonly UserManager<ApplicationUser> _userManage;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly LAFDbContext _context;

        public LoggedinUser(UserManager<ApplicationUser> userManage, RoleManager<IdentityRole> roleManager, LAFDbContext context)
        {
            _userManage = userManage;
            _roleManager = roleManager;
            _context = context;
        }
        
        public async Task<List<string>> UsersRoles(string name)
        {
            return (List<string>) await _userManage.GetRolesAsync( await _userManage.FindByNameAsync(name));  
        }
    }
}
