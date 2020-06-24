using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Services.AuthServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthServices
{

    public class ModuleAssignService : IModuleAssignService
    {
        private readonly LAFDbContext _context;

        public ModuleAssignService(LAFDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveModuleAccessPage(ModuleAccessPage userAccessPage)
        {
            try
            {
                if (userAccessPage.Id != 0)
                {
                    userAccessPage.updatedBy = userAccessPage.createdBy;
                    userAccessPage.updatedAt = DateTime.Now;
                    _context.ModuleAccessPages.Update(userAccessPage);
                }
                else
                {
                    userAccessPage.createdAt = DateTime.Now;
                    _context.ModuleAccessPages.Add(userAccessPage);
                }

                await _context.SaveChangesAsync();
                return userAccessPage.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<IEnumerable<ModuleAccessPage>> GetModuleAccessPages()
        {
            return await _context.ModuleAccessPages.Include(x => x.eRPModule).ToListAsync();
        }

        public async Task<IEnumerable<ModuleAccessPageViewModel>> GetModuleAccessPagesactive(string userRoleId)
        {
            List<LAFModule> eRPModules = _context.LAFModules.ToList();
            List<ModuleAccessPage> lstModuleAccess = _context.ModuleAccessPages.Where(x => x.applicationRoleId == userRoleId).ToList();
            List<ModuleAccessPageViewModel> data = new List<ModuleAccessPageViewModel>();
            foreach (LAFModule d in eRPModules)
            {
                var Mdata = lstModuleAccess.Where(x => x.inventoryModuleId == d.Id).ToList();
                int active = 0;
                if (Mdata.Count() > 0)
                {
                    active = 1;
                }
                data.Add(new ModuleAccessPageViewModel
                {
                    InventoryModuleId = d.Id,
                    InventoryModuleName = d.moduleName,
                    active = active

                });
            }
            return data;
        }

        public async Task<IEnumerable<LAFModule>> GetLAFModules()
        {
            return await _context.LAFModules.ToListAsync();
        }

        public async Task<bool> DeleteModuleAccesspageByUserTypeId(string userTypeid)
        {
            _context.ModuleAccessPages.RemoveRange(_context.ModuleAccessPages.Where(x => x.applicationRoleId == userTypeid));
            return 1 == await _context.SaveChangesAsync();
        }
    }

}
