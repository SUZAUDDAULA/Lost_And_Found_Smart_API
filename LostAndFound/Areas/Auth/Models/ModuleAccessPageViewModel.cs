using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.Auth.Models
{
    public class ModuleAccessPageViewModel
    {

        public int? InventoryModuleId { get; set; }
        public string InventoryModuleName { get; set; }

        public int active { get; set; }
    }
}
