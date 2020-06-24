using System.Collections.Generic;
using System.Threading.Tasks;

namespace LostAndFound.Services.Auth.Interfaces
{
    public interface ILoggedinUser
    {
        Task<List<string>> UsersRoles(string name);
        
    }
}
