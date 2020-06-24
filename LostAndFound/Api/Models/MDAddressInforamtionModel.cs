using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using System.Collections.Generic;

namespace LostAndFound.Api.Models
{
    public class MDAddressInforamtionModel
    {
        public IEnumerable<NationalIdentityType> nationalIdentityTypes { get; set; }
        public IEnumerable<Country> countries { get; set; }
        public IEnumerable<Division> divisions { get; set; }
        public IEnumerable<District> districts { get; set; }
        public IEnumerable<Thana> thanas { get; set; }
    }
}
