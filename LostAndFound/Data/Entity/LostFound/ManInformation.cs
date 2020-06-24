using LostAndFound.Data.Entity.Master;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class ManInformation:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation  { get; set; }
        public int? relationTypeId { get; set; }
        public RelationType relationType { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string name { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string aproxAge { get; set; }
        public int? agePeriodId { get; set; }
        public AgePeriod agePeriod { get; set; }
        public int? genderId { get; set; }
        public Gender gender { get; set; }
        public int? isHealthDisabled { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string fatherName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string motherName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string spouseName { get; set; }
        public int? nationalIdentityTypeId { get; set; }
        public NationalIdentityType nationalIdentityType { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string identityNo { get; set; }
        public int? numberTypeId { get; set; }
        public NumberType numberType { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string number { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string dateOfDeath { get; set; }
        public int? deadbodyConditionId { get; set; }
        public DeadbodyCondition deadbodyCondition { get; set; }
        [NotMapped]
        public string status { get; set; }

        [NotMapped]
        public PhysicalDescription physicalDescription { get; set; }
        [NotMapped]
        public DressDescription dressDescription { get; set; }
        [NotMapped]
        public IndentifyInfo indentifyInfo { get; set; }
        [NotMapped]
        public SpaceAndTime spaceAndTime { get; set; }

    }
}
