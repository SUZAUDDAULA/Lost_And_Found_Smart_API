using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class MetropolitanAreaViewModel
    {
        public int? areaId { get; set; }
        public string areaName { get; set; }
        public string areaNameBn { get; set; }
        public int? districtId { get; set; }
        public int? shortOrder { get; set; }
        public IEnumerable<MetropolitanArea> metropolitanAreas { get; set; }
    }
}
