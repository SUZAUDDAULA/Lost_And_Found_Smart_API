using LostAndFound.Areas.Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.AuthServices.Interfaces
{
    public interface IFilterRoleService
    {
        Task<IEnumerable<FileterRoleByUserViewModel>> GetFilterRoleByUserId(string id);
    }
}
