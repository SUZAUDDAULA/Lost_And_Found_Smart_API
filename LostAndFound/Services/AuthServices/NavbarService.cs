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
    public class NavbarService : INavbarService
    {
        private readonly LAFDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public NavbarService(LAFDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        #region Navbar
        public async Task<bool> DeleteNavbarItemById(int id)
        {
            _context.Navbars.Remove(_context.Navbars.Find(id));
            return 1 == await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavbarItem()
        {
            var result = await (from n in _context.Navbars
                                join m in _context.LAFModules on n.moduleId equals m.Id
                                join pn in _context.Navbars on n.parentID equals pn.Id into pon
                                from pnn in pon.DefaultIfEmpty()
                                where n.status == true
                                select new Navbar
                                {
                                    Id = n.Id,
                                    nameOptionBangla = n.nameOptionBangla,
                                    nameOption = n.nameOption,
                                    area = n.area,
                                    controller = n.controller,
                                    action = n.action,
                                    imageClass = n.imageClass,
                                    activeLi = n.activeLi,
                                    status = n.status,
                                    parentID = n.parentID,
                                    isParent = n.isParent,
                                    displayOrder = n.displayOrder,
                                    moduleId = n.moduleId,
                                    module = m,
                                    parentName = pnn.nameOption
                                }).ToListAsync();
            return result;
            //return await _context.Navbars.Include(x=>x.module).Where(x=>x.status == true).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavbarItemByRole(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var roles = await _userManager.GetRolesAsync(user);
            //var records=from n in _context.Navbars
            //            join b in _context.Navbars on n.parentID equals b.Id
            //            join c in _context.Navbars on b.parentID equals c.Id
            //            join m in _context.ERPModules on c.moduleId equals m.Id
            //            join u in _context.UserAccessPages on n.Id equals u.navbarId
            //            where u.applicationRoleId.Contains(roles.)

            var result = await (from n in _context.Navbars
                                join m in _context.LAFModules on n.moduleId equals m.Id
                                join pn in _context.Navbars on n.parentID equals pn.Id into pon
                                from pnn in pon.DefaultIfEmpty()
                                where n.status == true
                                select new Navbar
                                {
                                    Id = n.Id,
                                    nameOptionBangla = n.nameOptionBangla,
                                    nameOption = n.nameOption,
                                    area = n.area,
                                    controller = n.controller,
                                    action = n.action,
                                    imageClass = n.imageClass,
                                    activeLi = n.activeLi,
                                    status = n.status,
                                    parentID = n.parentID,
                                    isParent = n.isParent,
                                    displayOrder = n.displayOrder,
                                    moduleId = n.moduleId,
                                    module = m,
                                    parentName = pnn.nameOption
                                }).ToListAsync();
            return result;

        }

        public async Task<IEnumerable<Navbar>> GetNavbarItemByParent()
        {
            return await _context.Navbars.Where(x => x.isParent == 1 && x.status == true).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavbarItemByParentByModule(int moduleId, int isParent)
        {
            return await _context.Navbars.Where(x => x.status == true && x.moduleId == moduleId && x.isParent == isParent).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavbarItemByParentIdByModule(int moduleId, int isParent)
        {
            return await _context.Navbars.Where(x => x.status == true && x.moduleId == moduleId && x.parentID == isParent).AsNoTracking().ToListAsync();
        }

        public async Task<Navbar> GetNavbarItemById(int id)
        {
            return await _context.Navbars.FindAsync(id);
        }

        public async Task<int> GetNavbarParentIdById(int id)
        {
            var nab = await _context.Navbars.FindAsync(id);
            return nab.parentID;
        }

        public async Task<bool> SaveNavbarItem(Navbar navbar)
        {
            if (navbar.Id != 0)
                _context.Navbars.Update(navbar);
            else
                _context.Navbars.Add(navbar);

            return 1 == await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Navbar>> GetNavigationMenu(string userName)
        {
            var result = await ((from n in _context.Navbars
                                     //join em in _context.ERPModules on n.moduleId equals em.Id
                                 join uap in _context.UserAccessPages on n.Id equals uap.navbarId
                                 join ar in _context.Roles on uap.applicationRoleId equals ar.Id
                                 join aur in _context.UserRoles on ar.Id equals aur.RoleId
                                 join au in _context.Users on aur.UserId equals au.Id
                                 where au.UserName == (userName == "suza" ? au.UserName : userName)
                                 select new Navbar
                                 {
                                     Id = n.Id,
                                     //moduleName = em.moduleName,
                                     nameOption = n.nameOption,
                                     area = n.area,
                                     controller = n.controller,
                                     action = n.action,
                                     status = n.status,
                                     parentID = n.parentID,
                                     isParent = n.isParent,
                                     moduleId = n.moduleId,
                                     displayOrder = n.displayOrder
                                 }).Union(from n1 in _context.Navbars
                                          where n1.parentID == 0
                                          select new Navbar
                                          {
                                              Id = n1.Id,
                                              nameOption = n1.nameOption,
                                              area = n1.area,
                                              controller = n1.controller,
                                              action = n1.action,
                                              status = n1.status,
                                              parentID = n1.parentID,
                                              isParent = n1.isParent,
                                              moduleId = n1.moduleId,
                                              displayOrder = n1.displayOrder
                                          })).AsNoTracking().ToListAsync();
            return result;

        }

        #endregion

    }
}
