using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class DressDescription:Base
    {
        public int? manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public int? inTheBodyId { get; set; }
        public InTheBody inTheBody { get; set; }
        public int? inTheBodyColorId { get; set; }
        public Colors inTheBodyColor { get; set; }
        public int? inTheHeadId { get; set; }
        public InTheHead inTheHead { get; set; }
        public int? inTheHeadColorId { get; set; }
        public Colors inTheHeadColor { get; set; }
        public int? inTheEyeId { get; set; }
        public InTheEye inTheEye { get; set; }
        public int? inTheEyeColorId { get; set; }
        public Colors inTheEyeColor { get; set; }
        public int? inTheLegsId { get; set; }
        public InTheLegs inTheLegs { get; set; }
        public int? inTheLegsColorId { get; set; }
        public Colors inTheLegsColor { get; set; }
        public int? inTheThroatId { get; set; }
        public InTheThroat inTheThroat { get; set; }
        public int? inTheThroatColorId { get; set; }
        public Colors inTheThroatColor { get; set; }
        public int? inTheWaistId { get; set; }
        public InTheWaist inTheWaist { get; set; }
        public int? inTheWaistColorId { get; set; }
        public Colors inTheWaistColor { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal? shoesSize { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string shoesSizeType { get; set; }
    }
}
