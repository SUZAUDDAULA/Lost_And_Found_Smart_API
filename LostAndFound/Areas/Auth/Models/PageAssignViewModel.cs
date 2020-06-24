using LostAndFound.Data.Entity.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.Auth.Models
{
    public class PageAssignViewModel
    {
        public string userRole { get; set; }
        public int[] navbarId { get; set; }

        public IEnumerable<IdentityRole> identityRoles { get; set; }
        public IEnumerable<Navbar> parentNavItemList { get; set; }
        public IEnumerable<Navbar> childNavItemList { get; set; }
    }
}
