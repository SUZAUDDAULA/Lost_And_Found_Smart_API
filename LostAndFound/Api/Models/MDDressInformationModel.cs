using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.Collections.Generic;

namespace LostAndFound.Api.Models
{
    public class MDDressInformationModel
    {
        public IEnumerable<InTheBody> inTheBodies { get; set; }
        public IEnumerable<InTheHead> inTheHeads { get; set; }
        public IEnumerable<InTheEye> inTheEyes { get; set; }
        public IEnumerable<InTheLegs> inTheLegs { get; set; }
        public IEnumerable<InTheThroat> inTheThroats { get; set; }
        public IEnumerable<InTheWaist> inTheWaists { get; set; }
    }
}
