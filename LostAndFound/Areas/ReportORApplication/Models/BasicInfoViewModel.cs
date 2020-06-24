using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.Lang.ReportORApplication.Models;

namespace LostAndFound.Areas.ReportORApplication.Models
{
    public class BasicInfoViewModel 
    {
        public int? entryFor { get; set; }
        public int? entryType { get; set; }
        public int? productType { get; set; }

        public ApplicationLangViewModel Lang { get; set; }
    }
}
