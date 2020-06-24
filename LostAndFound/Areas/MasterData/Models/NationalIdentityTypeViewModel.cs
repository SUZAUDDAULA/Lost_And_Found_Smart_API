using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class NationalIdentityTypeViewModel
    {
        public int? nidId { get; set; }
        public string nidName { get; set; }
        public string nationalIdentityNameBn { get; set; }
        public NationalIdentityTypeLn fLang { get; set; }
        public IEnumerable<NationalIdentityType> nationalIdentityTypes { get; set; }
    }
}
