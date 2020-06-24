using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class PhysicalDescription:Base
    {
        public int? manInformationId { get; set; }
        public ManInformation manInformation { get; set; }
        public int? beardTypeId { get; set; }
        public BeardType beardType { get; set; }
        public int? bodyChinTypeId { get; set; }
        public BodyChinType bodyChinType { get; set; }
        public int? bodyColorId { get; set; }
        public BodyColor bodyColor { get; set; }
        public int? bodyStructureId { get; set; }
        public BodyStructure bodyStructure { get; set; }
        public int? earTypeId { get; set; }
        public EarType earType { get; set; }
        public int? eyeTypeId { get; set; }
        public EyeType eyeType { get; set; }
        public int? faceShapeTypeId { get; set; }
        public FaceShapeType faceShapeType { get; set; }
        public int? foreHeadTypeId { get; set; }
        public ForeHeadType foreHeadType { get; set; }
        public int? hairTypeId { get; set; }
        public HairType hairType { get; set; }
        public int? headTypeId { get; set; }
        public HeadType headType { get; set; }
        public int? moustacheTypeId { get; set; }
        public MoustacheType moustacheType { get; set; }
        public int? mouthTypeId { get; set; }
        public MouthType mouthType { get; set; }
        public int? neckTypeId { get; set; }
        public NeckType neckType { get; set; }
        public int? noseTypeId { get; set; }
        public NoseType noseType { get; set; }
        public int? specialBodyConditionId { get; set; }
        public SpecialBodyCondition specialBodyCondition { get; set; }
        public int? teethTypeId { get; set; }
        public TeethType teethType { get; set; }
        public decimal? weight { get; set; }
        public decimal? heightFeet { get; set; }
        public decimal? heightInch { get; set; }
        public int? specialBirthMarkTypeId { get; set; }
        public SpecialBirthMarkType specialBirthMarkType { get; set; }
        public int? specialBirthMarkBodyPartId { get; set; }
        public SpecialBirthMarkBodyPart specialBirthMarkBodyPart { get; set; }
        public int? specialBirthMarkBodyPartPositionId { get; set; }
        public SpecialBirthMarkBodyPartPosition specialBirthMarkBodyPartPosition { get; set; }
        [Column(TypeName = "NVARCHAR(200)")]
        public string visibleTatto { get; set; }
        [Column(TypeName = "NVARCHAR(200)")]
        public string otherIdentityfyMark { get; set; }
    }
}
