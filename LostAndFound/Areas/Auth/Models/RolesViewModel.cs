using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.Auth.Models
{
    public class RolesViewModel
    {
        public int Id { get; set; }
        public string name { get; set; }

        public IEnumerable<IdentityRole> identityRoles { get; set; }
    }
}
