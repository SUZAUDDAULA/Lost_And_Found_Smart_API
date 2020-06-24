using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData.Interfaces
{
    public interface IExtendedMasterDataService
    {
        #region Address Source Type
        Task<int> SaveAddressSourceType(AddressSourceType addressSourceType);
        Task<IEnumerable<AddressSourceType>> GetAllAddressSourceType();
        Task<int> DeleteAddressSourceTypeById(int id);
        #endregion

        #region BeardType
        Task<int> SaveBeardType(BeardType beardType);
        Task<IEnumerable<BeardType>> GetAllBeardType();
        Task<int> DeleteBeardTypeById(int id);
        #endregion

        #region BodyChinType
        Task<int> SaveBodyChinType(BodyChinType bodyChinType);
        Task<IEnumerable<BodyChinType>> GetAllBodyChinType();
        Task<int> DeleteBodyChinTypeById(int id);
        #endregion

        #region BodyColor
        Task<int> SaveBodyColor(BodyColor bodyColor);
        Task<IEnumerable<BodyColor>> GetAllBodyColor();
        Task<int> DeleteBodyColorById(int id);
        #endregion

        #region BodyStructure
        Task<int> SaveBodyStructure(BodyStructure bodyStructure);
        Task<IEnumerable<BodyStructure>> GetAllBodyStructure();
        Task<int> DeleteBodyStructureById(int id);
        #endregion

        #region CareType
        Task<int> SaveCareType(CareType careType);
        Task<IEnumerable<CareType>> GetAllCareType();
        Task<int> DeleteCareTypeById(int id);
        #endregion

        #region Complextion
        Task<int> SaveComplextion(Complextion complextion);
        Task<IEnumerable<Complextion>> GetAllComplextion();
        Task<int> DeleteComplextionById(int id);
        #endregion

        #region DeadbodyCondition
        Task<int> SaveDeadbodyCondition(DeadbodyCondition deadbodyCondition);
        Task<IEnumerable<DeadbodyCondition>> GetAllDeadbodyCondition();
        Task<int> DeleteDeadbodyConditionById(int id);
        #endregion

        #region DeathType
        Task<int> SaveDeathType(DeathType deathType);
        Task<IEnumerable<DeathType>> GetAllDeathType();
        Task<int> DeleteDeathTypeById(int id);
        #endregion

        #region Age Period
        Task<int> SaveAgePeriod(AgePeriod agePeriod);
        Task<IEnumerable<AgePeriod>> GetAllAgePeriod();
        Task<int> DeleteAgePeriodById(int id);
        #endregion

        #region EarType
        Task<int> SaveEarType(EarType earType);
        Task<IEnumerable<EarType>> GetAllEarType();
        Task<int> DeleteEarTypeById(int id);
        #endregion

        #region EyeType
        Task<int> SaveEyeType(EyeType eyeType);
        Task<IEnumerable<EyeType>> GetAllEyeType();
        Task<int> DeleteEyeTypeById(int id);
        #endregion

        #region FaceShapeType
        Task<int> SaveFaceShapeType(FaceShapeType faceShapeType);
        Task<IEnumerable<FaceShapeType>> GetAllFaceShapeType();
        Task<int> DeleteFaceShapeTypeById(int id);
        #endregion

        #region ForeHeadType
        Task<int> SaveForeHeadType(ForeHeadType earType);
        Task<IEnumerable<ForeHeadType>> GetAllForeHeadType();
        Task<int> DeleteForeHeadTypeById(int id);
        #endregion

        #region HairType
        Task<int> SaveHairType(HairType hairType);
        Task<IEnumerable<HairType>> GetAllHairType();
        Task<int> DeleteHairTypeById(int id);
        #endregion

        #region HeadType
        Task<int> SaveHeadType(HeadType headType);
        Task<IEnumerable<HeadType>> GetAllHeadType();
        Task<int> DeleteHeadTypeById(int id);
        #endregion

        #region InTheBody
        Task<int> SaveInTheBody(InTheBody inTheBody);
        Task<IEnumerable<InTheBody>> GetAllInTheBody();
        Task<int> DeleteInTheBodyById(int id);
        #endregion

        #region InTheHead
        Task<int> SaveInTheHead(InTheHead inTheHead);
        Task<IEnumerable<InTheHead>> GetAllInTheHead();
        Task<int> DeleteInTheHeadById(int id);
        #endregion

        #region InTheEye
        Task<int> SaveInTheHead(InTheEye inTheEye);
        Task<IEnumerable<InTheEye>> GetAllInTheEye();
        Task<int> DeleteInTheEyeById(int id);
        #endregion

        #region InTheLegs
        Task<int> SaveInTheLegs(InTheLegs inTheLegs);
        Task<IEnumerable<InTheLegs>> GetAllInTheLegs();
        Task<int> DeleteInTheLegsById(int id);
        #endregion

        #region InTheThroat
        Task<int> SaveInTheThroat(InTheThroat inTheThroat);
        Task<IEnumerable<InTheThroat>> GetAllInTheThroat();
        Task<int> DeleteInTheThroatById(int id);
        #endregion

        #region InTheWaist
        Task<int> SaveInTheWaist(InTheWaist inTheWaist);
        Task<IEnumerable<InTheWaist>> GetAllInTheWaist();
        Task<int> DeleteInTheWaistById(int id);
        #endregion

        #region MaritalStatus
        Task<int> SaveMaritalStatus(MaritalStatus maritalStatus);
        Task<IEnumerable<MaritalStatus>> GetAllMaritalStatus();
        Task<int> DeleteMaritalStatusById(int id);
        #endregion

        #region MeasurementType
        Task<int> SaveMeasurementType(MeasurementType measurementType);
        Task<IEnumerable<MeasurementType>> GetAllMeasurementType();
        Task<int> DeleteMeasurementTypeById(int id);
        #endregion

        #region MeterialCondition
        Task<int> SaveMeterialCondition(MeterialCondition meterialCondition);
        Task<IEnumerable<MeterialCondition>> GetAllMeterialCondition();
        Task<int> DeleteMeterialConditionById(int id);
        #endregion

        #region MoustacheType
        Task<int> SaveMoustacheType(MoustacheType moustacheType);
        Task<IEnumerable<MoustacheType>> GetAllMoustacheType();
        Task<int> DeleteMoustacheTypeById(int id);
        #endregion

        #region MouthType
        Task<int> SaveMouthType(MouthType mouthType);
        Task<IEnumerable<MouthType>> GetAllMouthType();
        Task<int> DeleteMouthTypeById(int id);
        #endregion

        #region NeckType
        Task<int> SaveNeckType(NeckType neckType);
        Task<IEnumerable<NeckType>> GetAllNeckType();
        Task<int> DeleteNeckTypeById(int id);
        #endregion

        #region NoseType
        Task<int> SaveNoseType(NoseType noseType);
        Task<IEnumerable<NoseType>> GetAllNoseType();
        Task<int> DeleteNoseTypeById(int id);
        #endregion

        #region NumberType
        Task<int> SaveNumberType(NumberType numberType);
        Task<IEnumerable<NumberType>> GetAllNumberType();
        Task<int> DeleteNumberTypeById(int id);
        #endregion

        #region PurposeOfVisite
        Task<int> SavePurposeOfVisite(PurposeOfVisite purposeOfVisite);
        Task<IEnumerable<PurposeOfVisite>> GetAllPurposeOfVisite();
        Task<int> DeletePurposeOfVisiteById(int id);
        #endregion

        #region Religion
        Task<int> SaveReligion(Religion religion);
        Task<IEnumerable<Religion>> GetAllReligion();
        Task<int> DeleteReligionById(int id);
        #endregion

        #region ReligionCust
        Task<int> SaveReligionCust(ReligionCust religionCust);
        Task<IEnumerable<ReligionCust>> GetAllReligionCust();
        Task<IEnumerable<ReligionCust>> GetAllReligionCustByReligionId(int id);
        Task<int> DeleteReligionCustById(int id);
        #endregion

        #region SpecialBodyCondition
        Task<int> SaveSpecialBodyCondition(SpecialBodyCondition specialBodyCondition);
        Task<IEnumerable<SpecialBodyCondition>> GetAllSpecialBodyCondition();
        Task<int> DeleteSpecialBodyConditionById(int id);
        #endregion

        #region TeethType
        Task<int> SaveTeethType(TeethType teethType);
        Task<IEnumerable<TeethType>> GetAllTeethType();
        Task<int> DeleteTeethTypeById(int id);
        #endregion

        #region Relation Type
        Task<int> SaveRelationType(RelationType relationType);
        Task<IEnumerable<RelationType>> GetAllRelationType();
        Task<int> DeleteRelationTypeById(int id);
        #endregion

        #region Habit
        Task<int> SaveHabit(Habit habit);
        Task<IEnumerable<Habit>> GetAllHabit();
        Task<int> DeleteHabitById(int id);
        #endregion

        #region Habit
        Task<int> SaveSpeech(Speech speech);
        Task<IEnumerable<Speech>> GetAllSpeech();
        Task<int> DeleteSpeechById(int id);
        #endregion

        #region Special Birth Mark Type
        Task<int> SaveSpecialBirthMarkType(SpecialBirthMarkType specialBirthMarkType);
        Task<IEnumerable<SpecialBirthMarkType>> GetAllSpecialBirthMarkType();
        Task<int> DeleteSpecialBirthMarkTypeById(int id);
        #endregion

        #region Special Birth Mark Body Part
        Task<int> SaveSpecialBirthMarkBodyPart(SpecialBirthMarkBodyPart specialBirthMarkBodyPart);
        Task<IEnumerable<SpecialBirthMarkBodyPart>> GetAllSpecialBirthMarkBodyPart();
        Task<int> DeleteSpecialBirthMarkBodyPartById(int id);
        #endregion

        #region Special Birth Mark Body Part Position
        Task<int> SaveSpecialBirthMarkBodyPartPosition(SpecialBirthMarkBodyPartPosition specialBirthMarkBodyPartPosition);
        Task<IEnumerable<SpecialBirthMarkBodyPartPosition>> GetAllSpecialBirthMarkBodyPartPosition();
        Task<int> DeleteSpecialBirthMarkBodyPartPositionById(int id);
        #endregion

    }
}
