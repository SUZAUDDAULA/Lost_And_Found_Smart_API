using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Data.Entity.Auth
{
    public class ModuleAccessPage : Base
    {
        public int? inventoryModuleId { get; set; }
        public LAFModule eRPModule { get; set; }
        
        public string applicationRoleId { get; set; }
        public IdentityRole applicationRole { get; set; }
    }
}
