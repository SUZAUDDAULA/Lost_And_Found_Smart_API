using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.MasterData.Models.Lang
{
    public class DocumentTypeLn
    {
        public string documentType { get; set; }
        public string documentCategory { get; set; }
        public string documentCategoryBn { get; set; }
        public string title { get; set; }
        public string categoryTitle { get; set; }
        public string photo { get; set; }
        public string listTitle { get; set; }
        public string categoryListTitle { get; set; }
        public string action { get; set; }
        public string submitButton { get; set; }
        public string refreshButton { get; set; }
    }
}
