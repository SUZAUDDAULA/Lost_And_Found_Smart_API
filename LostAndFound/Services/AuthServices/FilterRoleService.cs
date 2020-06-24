using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Services.AuthServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthServices
{
    public class FilterRoleService : IFilterRoleService
    {

        private readonly LAFDbContext _context;

        public FilterRoleService( LAFDbContext _context)
        {
            this._context = _context;
        }

        public async Task<IEnumerable<FileterRoleByUserViewModel>> GetFilterRoleByUserId(string id)
        {
            var result = await (from r in _context.Roles
                                join AR in (from a in _context.UserRoles
                                            where a.UserId == id
                                            select a) on r.Id equals AR.RoleId into aar
                                from ccr in aar.DefaultIfEmpty()
                                select new FileterRoleByUserViewModel
                                {
                                    roleId = r.Id,
                                    roleName = r.Name,
                                    arRoleId = ccr.RoleId
                                }).AsNoTracking().ToListAsync();

                                return result;
            
        }
    }
}
