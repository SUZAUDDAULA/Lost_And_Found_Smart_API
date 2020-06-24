using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.LostFound.Models
{
    public class SearchViewModel
    {
        public string Surrounding { get; set; }
        public string lostFound { get; set; }
        public string imageSearch { get; set; }
        public SearchLn searchLn { get; set; }
    }
}
