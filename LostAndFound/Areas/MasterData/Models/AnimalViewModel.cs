using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class AnimalViewModel
    {
        public int? animalId { get; set; }
        public string animalName { get; set; }
        public string animalNameBn { get; set; }
        public IFormFile formFile { get; set; }
        public AnimalLn fLang { get; set; }
        public IEnumerable<Animal> animals { get; set; }
    }
}
