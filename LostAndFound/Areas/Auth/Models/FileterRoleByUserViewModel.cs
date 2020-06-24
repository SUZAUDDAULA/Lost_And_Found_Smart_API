using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.Auth.Models
{
    public class FileterRoleByUserViewModel
    {
        public string roleId { get; set; }
        public string roleName { get; set; }
        public string arRoleId { get; set; }

        //public IEnumerable<IdentityRole> identityRoles { get; set; }
    }
}
