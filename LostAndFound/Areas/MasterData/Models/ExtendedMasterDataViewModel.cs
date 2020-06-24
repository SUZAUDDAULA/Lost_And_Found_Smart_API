using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Areas.MasterData.Models.Lang;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using Microsoft.AspNetCore.Http;

namespace LostAndFound.Areas.MasterData.Models
{
    public class ExtendedMasterDataViewModel
    {
        public int? id { get; set; }
        public string nameBangla { get; set; }
        public string nameEnglish { get; set; }
        public IFormFile img { get; set; }
        public int? shortOrder { get; set; }
        public string colorCode { get; set; }
        public int? religionId { get; set; }

        public ExtendedMasterDataLn fLang { get; set; }

        public IEnumerable<AddressSourceType> AddressSourceType { get; set; }
        public IEnumerable<BeardType>  BeardTypes { get; set; }
        public IEnumerable<BodyChinType>  BodyChinTypes { get; set; }
        public IEnumerable<BodyColor>  BodyColors { get; set; }
        public IEnumerable<BodyStructure>  BodyStructures { get; set; }
        public IEnumerable<CareType>  CareTypes { get; set; }
        public IEnumerable<Complextion>  Complextions { get; set; }
        public IEnumerable<DeadbodyCondition>  DeadbodyConditions { get; set; }
        public IEnumerable<DeathType>  DeathTypes { get; set; }
        public IEnumerable<AgePeriod>  AgePeriods { get; set; }
        public IEnumerable<EarType>  EarTypes { get; set; }
        public IEnumerable<EyeType>  EyeTypes { get; set; }
        public IEnumerable<FaceShapeType>  FaceShapeTypes { get; set; }
        public IEnumerable<ForeHeadType>  ForeHeadTypes { get; set; }
        public IEnumerable<HairType>  HairTypes { get; set; }
        public IEnumerable<HeadType>  HeadTypes { get; set; }
        public IEnumerable<InTheBody>  InTheBodys { get; set; }
        public IEnumerable<InTheHead>  InTheHeads { get; set; }
        public IEnumerable<InTheLegs>  InTheLegs { get; set; }
        public IEnumerable<InTheThroat>  InTheThroats { get; set; }
        public IEnumerable<InTheWaist>  InTheWaists { get; set; }
        public IEnumerable<MaritalStatus>  MaritalStatus { get; set; }
        public IEnumerable<MeasurementType>  MeasurementTypes { get; set; }
        public IEnumerable<MeterialCondition>  MeterialConditions { get; set; }
        public IEnumerable<MoustacheType>  MoustacheTypes { get; set; }
        public IEnumerable<MouthType>  MouthTypes { get; set; }
        public IEnumerable<NeckType>  NeckTypes { get; set; }
        public IEnumerable<NoseType>  NoseTypes { get; set; }
        public IEnumerable<NumberType>  NumberTypes { get; set; }
        public IEnumerable<PurposeOfVisite>  PurposeOfVisites { get; set; }
        public IEnumerable<Religion>  Religions { get; set; }
        public IEnumerable<ReligionCust>  ReligionCusts { get; set; }
        public IEnumerable<SpecialBodyCondition> SpecialBodyConditions { get; set; }
        public IEnumerable<TeethType>  TeethTypes { get; set; }
        public IEnumerable<RelationType>  relationTypes { get; set; }
        public IEnumerable<Habit>  habits { get; set; }
        public IEnumerable<Speech>  speeches { get; set; }
        public IEnumerable<SpecialBirthMarkType>  specialBirthMarkTypes { get; set; }
        public IEnumerable<SpecialBirthMarkBodyPart>  specialBirthMarkBodyParts { get; set; }
        public IEnumerable<SpecialBirthMarkBodyPartPosition>  specialBirthMarkBodyPartPositions { get; set; }


    }
}
