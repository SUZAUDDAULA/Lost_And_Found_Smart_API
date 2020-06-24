using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Models.Lang;

namespace LostAndFound.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<GDType> gDType { get; set; }
        public IEnumerable<GDInformation> gDInformation { get; set; }
        public DashboardLn dashboardLn { get; set; }
    }
}
