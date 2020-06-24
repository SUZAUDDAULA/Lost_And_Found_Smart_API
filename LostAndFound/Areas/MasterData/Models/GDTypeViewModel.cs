using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Areas.MasterData.Models
{
    public class GDTypeViewModel
    {
        public int? gdTypeId { get; set; }
        public string gdTypeName { get; set; }
        public string gdTypeNameBn { get; set; }
        public GDTypeLn fLang { get; set; }
        public IEnumerable<GDType> gDTypes { get; set; }
    }
}
