using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.Auth
{
    public class UserAccessPage:Base
    {
   
        public int? navbarId { get; set; }
        public Navbar navbar { get; set; }

        public int? isAccess { get; set; }

        public string applicationRoleId { get; set; }
        public IdentityRole applicationRole { get; set; }
    }
}
