using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class ColorViewModel
    {
        public int? colorId { get; set; }
        public string colorName { get; set; }
        public string colorNameBn { get; set; }
        public string colorCode { get; set; }
        public ColorLn fLang { get; set; }
        public IEnumerable<Colors> colors { get; set; }
    }
}
