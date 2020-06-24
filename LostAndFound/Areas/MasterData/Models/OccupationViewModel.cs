using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class OccupationViewModel
    {
        public int? occupationId { get; set; }
        public string name { get; set; }
        public string nameBn { get; set; }
        public string imagePath { get; set; }
        public string shortOrder { get; set; }
        public IFormFile formFile { get; set; }
        public IEnumerable<Occupation> occupations { get; set; }
        public OccupationLn fLang { get; set; }

    }
}
