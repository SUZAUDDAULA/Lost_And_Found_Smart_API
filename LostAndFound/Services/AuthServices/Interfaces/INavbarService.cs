using LostAndFound.Data.Entity.Auth;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Sevices.AuthServices.Interfaces
{
    public interface INavbarService
    {

        Task<bool> DeleteNavbarItemById(int id);
        Task<IEnumerable<Navbar>> GetNavbarItem();
        Task<IEnumerable<Navbar>> GetNavigationMenu(string userName);
        Task<IEnumerable<Navbar>> GetNavbarItemByParent();
        Task<IEnumerable<Navbar>> GetNavbarItemByParentByModule(int moduleId, int isParent);
        Task<IEnumerable<Navbar>> GetNavbarItemByParentIdByModule(int moduleId, int isParent);
        Task<Navbar> GetNavbarItemById(int id);
        Task<bool> SaveNavbarItem(Navbar navbar);
        Task<int> GetNavbarParentIdById(int id);
    }
}
