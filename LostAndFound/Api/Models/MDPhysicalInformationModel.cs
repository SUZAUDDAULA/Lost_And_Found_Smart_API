using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.Collections.Generic;

namespace LostAndFound.Api.Models
{
    public class MDPhysicalInformationModel
    {
        public IEnumerable<AgePeriod> agePeriods { get; set; }
        public IEnumerable<BeardType> beardTypes { get; set; }
        public IEnumerable<BodyChinType> bodyChinTypes { get; set; }
        public IEnumerable<BodyColor> bodyColors { get; set; }
        public IEnumerable<BodyStructure> bodyStructures { get; set; }
        public IEnumerable<DeadbodyCondition> deadbodyConditions { get; set; }
        public IEnumerable<DeathType> deathTypes { get; set; }
        public IEnumerable<EarType> earTypes { get; set; }
        public IEnumerable<EyeType> eyeTypes { get; set; }
        public IEnumerable<FaceShapeType> faceShapeTypes { get; set; }
        public IEnumerable<ForeHeadType> foreHeadTypes { get; set; }
        public IEnumerable<HairType> hairTypes { get; set; }
        public IEnumerable<HeadType> headTypes { get; set; }
        public IEnumerable<MoustacheType> moustacheTypes { get; set; }
        public IEnumerable<MouthType> mouthTypes { get; set; }
        public IEnumerable<NeckType> neckTypes { get; set; }
        public IEnumerable<NoseType> noseTypes { get; set; }
        public IEnumerable<SpecialBodyCondition> specialBodyConditions { get; set; }
        public IEnumerable<TeethType> teethTypes { get; set; }
        public IEnumerable<SpecialBirthMarkType> specialBirthMarkTypes { get; set; }
        public IEnumerable<SpecialBirthMarkBodyPart> specialBirthMarkBodyParts { get; set; }
        public IEnumerable<SpecialBirthMarkBodyPartPosition> specialBirthMarkBodyPartPositions { get; set; }
    }
}
