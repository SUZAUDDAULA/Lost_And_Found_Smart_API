using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Api.Models;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExtendMasterController : ControllerBase
    {
        private readonly IExtendedMasterDataService extendedMasterDataService;
        private readonly ILostAndFoundType lostAndFoundType;

        public ExtendMasterController(ILostAndFoundType lostAndFoundType, IExtendedMasterDataService extendedMasterDataService)
        {
            //this.extendedMasterDataService = extendedMasterDataService;
            this.lostAndFoundType = lostAndFoundType;
            this.extendedMasterDataService = extendedMasterDataService;
        }

        // GET: api/ExtendMaster/GetAllDocumentType
        [HttpGet]
        public async Task<IEnumerable<DocumentType>> GetAllDocumentType()
        {

            var documentTypes = await lostAndFoundType.GetDocumentTypes();

            return documentTypes;
        }

        // GET: api/ExtendMaster/GetAllAddressSourceType
        [HttpGet]
        public async Task<IEnumerable<AddressSourceType>> GetAllAddressSourceType()
        {
            var addressSourceTypes = await extendedMasterDataService.GetAllAddressSourceType();
            return addressSourceTypes;
        }


        // GET: api/ExtendMaster/GetAllBeardType
        [HttpGet]
        public async Task<IEnumerable<BeardType>> GetAllBeardType()
        {
            var result = await extendedMasterDataService.GetAllBeardType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllBodyChinType
        [HttpGet]
        public async Task<IEnumerable<BodyChinType>> GetAllBodyChinType()
        {
            var result = await extendedMasterDataService.GetAllBodyChinType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllBodyColor
        [HttpGet]
        public async Task<IEnumerable<BodyColor>> GetAllBodyColor()
        {
            var result = await extendedMasterDataService.GetAllBodyColor();
            return result;
        }

        // GET: api/ExtendMaster/GetAllBodyStructure
        [HttpGet]
        public async Task<IEnumerable<BodyStructure>> GetAllBodyStructure()
        {
            var result = await extendedMasterDataService.GetAllBodyStructure();
            return result;
        }

        // GET: api/ExtendMaster/GetAllCareType
        [HttpGet]
        public async Task<IEnumerable<CareType>> GetAllCareType()
        {
            var result = await extendedMasterDataService.GetAllCareType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllComplextion
        [HttpGet]
        public async Task<IEnumerable<Complextion>> GetAllComplextion()
        {
            var result = await extendedMasterDataService.GetAllComplextion();
            return result;
        }

        // GET: api/ExtendMaster/GetAllDeadbodyCondition
        [HttpGet]
        public async Task<IEnumerable<DeadbodyCondition>> GetAllDeadbodyCondition()
        {
            var result = await extendedMasterDataService.GetAllDeadbodyCondition();
            return result;
        }

        // GET: api/ExtendMaster/GetAllDeathType
        [HttpGet]
        public async Task<IEnumerable<DeathType>> GetAllDeathType()
        {
            var result = await extendedMasterDataService.GetAllDeathType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllAgePeriod
        [HttpGet]
        public async Task<IEnumerable<AgePeriod>> GetAllAgePeriod()
        {
            var result = await extendedMasterDataService.GetAllAgePeriod();
            return result;
        }

        // GET: api/ExtendMaster/GetAllEarType
        [HttpGet]
        public async Task<IEnumerable<EarType>> GetAllEarType()
        {
            var result = await extendedMasterDataService.GetAllEarType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllEyeType
        [HttpGet]
        public async Task<IEnumerable<EyeType>> GetAllEyeType()
        {
            var result = await extendedMasterDataService.GetAllEyeType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllFaceShapeType
        [HttpGet]
        public async Task<IEnumerable<FaceShapeType>> GetAllFaceShapeType()
        {
            var result = await extendedMasterDataService.GetAllFaceShapeType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllForeHeadType
        [HttpGet]
        public async Task<IEnumerable<ForeHeadType>> GetAllForeHeadType()
        {
            var result = await extendedMasterDataService.GetAllForeHeadType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllHairType
        [HttpGet]
        public async Task<IEnumerable<HairType>> GetAllHairType()
        {
            var result = await extendedMasterDataService.GetAllHairType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllHeadType
        [HttpGet]
        public async Task<IEnumerable<HeadType>> GetAllHeadType()
        {
            var result = await extendedMasterDataService.GetAllHeadType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheBody
        [HttpGet]
        public async Task<IEnumerable<InTheBody>> GetAllInTheBody()
        {
            var result = await extendedMasterDataService.GetAllInTheBody();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheHead
        [HttpGet]
        public async Task<IEnumerable<InTheHead>> GetAllInTheHead()
        {
            var result = await extendedMasterDataService.GetAllInTheHead();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheLegs
        [HttpGet]
        public async Task<IEnumerable<InTheLegs>> GetAllInTheLegs()
        {
            var result = await extendedMasterDataService.GetAllInTheLegs();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheEye
        [HttpGet]
        public async Task<IEnumerable<InTheEye>> GetAllInTheEye()
        {
            var result = await extendedMasterDataService.GetAllInTheEye();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheThroat
        [HttpGet]
        public async Task<IEnumerable<InTheThroat>> GetAllInTheThroat()
        {
            var result = await extendedMasterDataService.GetAllInTheThroat();
            return result;
        }

        // GET: api/ExtendMaster/GetAllInTheWaist
        [HttpGet]
        public async Task<IEnumerable<InTheWaist>> GetAllInTheWaist()
        {
            var result = await extendedMasterDataService.GetAllInTheWaist();
            return result;
        }

        // GET: api/ExtendMaster/GetAllMaritalStatus
        [HttpGet]
        public async Task<IEnumerable<MaritalStatus>> GetAllMaritalStatus()
        {
            var result = await extendedMasterDataService.GetAllMaritalStatus();
            return result;
        }

        // GET: api/ExtendMaster/GetAllMeasurementType
        [HttpGet]
        public async Task<IEnumerable<MeasurementType>> GetAllMeasurementType()
        {
            var result = await extendedMasterDataService.GetAllMeasurementType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllMeterialCondition
        [HttpGet]
        public async Task<IEnumerable<MeterialCondition>> GetAllMeterialCondition()
        {
            var result = await extendedMasterDataService.GetAllMeterialCondition();
            return result;
        }

        // GET: api/ExtendMaster/GetAllMoustacheType
        [HttpGet]
        public async Task<IEnumerable<MoustacheType>> GetAllMoustacheType()
        {
            var result = await extendedMasterDataService.GetAllMoustacheType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllMouthType
        [HttpGet]
        public async Task<IEnumerable<MouthType>> GetAllMouthType()
        {
            var result = await extendedMasterDataService.GetAllMouthType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllNeckType
        [HttpGet]
        public async Task<IEnumerable<NeckType>> GetAllNeckType()
        {
            var result = await extendedMasterDataService.GetAllNeckType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllNoseType
        [HttpGet]
        public async Task<IEnumerable<NoseType>> GetAllNoseType()
        {
            var result = await extendedMasterDataService.GetAllNoseType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllNumberType
        [HttpGet]
        public async Task<IEnumerable<NumberType>> GetAllNumberType()
        {
            var result = await extendedMasterDataService.GetAllNumberType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllPurposeOfVisite
        [HttpGet]
        public async Task<IEnumerable<PurposeOfVisite>> GetAllPurposeOfVisite()
        {
            var result = await extendedMasterDataService.GetAllPurposeOfVisite();
            return result;
        }

        // GET: api/ExtendMaster/GetAllReligion
        [HttpGet]
        public async Task<IEnumerable<Religion>> GetAllReligion()
        {
            var result = await extendedMasterDataService.GetAllReligion();
            return result;
        }

        // GET: api/ExtendMaster/GetAllReligionCust
        [HttpGet]
        public async Task<IEnumerable<ReligionCust>> GetAllReligionCust()
        {
            var result = await extendedMasterDataService.GetAllReligionCust();
            return result;
        }

        // GET: api/ExtendMaster/GetAllReligionCustByReligionId
        [HttpGet("{id}")]
        public async Task<IEnumerable<ReligionCust>> GetAllReligionCustByReligionId(int id)
        {
            var result = await extendedMasterDataService.GetAllReligionCustByReligionId(id);
            return result;
        }

        // GET: api/ExtendMaster/GetAllSpecialBodyCondition
        [HttpGet]
        public async Task<IEnumerable<SpecialBodyCondition>> GetAllSpecialBodyCondition()
        {
            var result = await extendedMasterDataService.GetAllSpecialBodyCondition();
            return result;
        }

        // GET: api/ExtendMaster/GetAllTeethType
        [HttpGet]
        public async Task<IEnumerable<TeethType>> GetAllTeethType()
        {
            var result = await extendedMasterDataService.GetAllTeethType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllPersonRelation
        [HttpGet]
        public async Task<IEnumerable<RelationType>> GetAllPersonRelation()
        {
            var result = await extendedMasterDataService.GetAllRelationType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllSpecialBirthMarkType
        [HttpGet]
        public async Task<IEnumerable<SpecialBirthMarkType>> GetAllSpecialBirthMarkType()
        {
            var result = await extendedMasterDataService.GetAllSpecialBirthMarkType();
            return result;
        }

        // GET: api/ExtendMaster/GetAllSpecialBirthMarkBodyPart
        [HttpGet]
        public async Task<IEnumerable<SpecialBirthMarkBodyPart>> GetAllSpecialBirthMarkBodyPart()
        {
            var result = await extendedMasterDataService.GetAllSpecialBirthMarkBodyPart();
            return result;
        }

        // GET: api/ExtendMaster/GetAllSpecialBirthMarkBodyPartPosition
        [HttpGet]
        public async Task<IEnumerable<SpecialBirthMarkBodyPartPosition>> GetAllSpecialBirthMarkBodyPartPosition()
        {
            var result = await extendedMasterDataService.GetAllSpecialBirthMarkBodyPartPosition();
            return result;
        }

        // GET: api/ExtendMaster/GetPersonalInformationMasterData
        [HttpGet]
        public async Task<MDPersonalInformationModel> GetPersonalInformationMasterData()
        {
            MDPersonalInformationModel model = new MDPersonalInformationModel
            {
                genders = await lostAndFoundType.GetAllGender(),
                religions = await extendedMasterDataService.GetAllReligion(),
                religionCusts=await extendedMasterDataService.GetAllReligionCust(),
                relationTypes=await extendedMasterDataService.GetAllRelationType(),
                occupations=await lostAndFoundType.GetOccupation(),
                maritalStatuses=await extendedMasterDataService.GetAllMaritalStatus(),
                habits=await extendedMasterDataService.GetAllHabit(),
                speeches=await extendedMasterDataService.GetAllSpeech(),
                numberTypes=await extendedMasterDataService.GetAllNumberType()
            };
            return model;
        }

        // GET: api/ExtendMaster/GetPhysicalInformationMasterData
        [HttpGet]
        public async Task<MDPhysicalInformationModel> GetPhysicalInformationMasterData()
        {
            MDPhysicalInformationModel model = new MDPhysicalInformationModel
            {
                agePeriods= await extendedMasterDataService.GetAllAgePeriod(),
                beardTypes = await extendedMasterDataService.GetAllBeardType(),
                bodyChinTypes = await extendedMasterDataService.GetAllBodyChinType(),
                bodyColors = await extendedMasterDataService.GetAllBodyColor(),
                bodyStructures = await extendedMasterDataService.GetAllBodyStructure(),
                deadbodyConditions = await extendedMasterDataService.GetAllDeadbodyCondition(),
                deathTypes=await extendedMasterDataService.GetAllDeathType(),
                earTypes=await extendedMasterDataService.GetAllEarType(),
                eyeTypes=await extendedMasterDataService.GetAllEyeType(),
                faceShapeTypes=await extendedMasterDataService.GetAllFaceShapeType(),
                foreHeadTypes=await extendedMasterDataService.GetAllForeHeadType(),
                hairTypes=await extendedMasterDataService.GetAllHairType(),
                headTypes=await extendedMasterDataService.GetAllHeadType(),
                moustacheTypes=await extendedMasterDataService.GetAllMoustacheType(),
                mouthTypes=await extendedMasterDataService.GetAllMouthType(),
                neckTypes=await extendedMasterDataService.GetAllNeckType(),
                noseTypes=await extendedMasterDataService.GetAllNoseType(),
                specialBodyConditions=await extendedMasterDataService.GetAllSpecialBodyCondition(),
                teethTypes=await extendedMasterDataService.GetAllTeethType(),
                specialBirthMarkTypes=await extendedMasterDataService.GetAllSpecialBirthMarkType(),
                specialBirthMarkBodyParts=await extendedMasterDataService.GetAllSpecialBirthMarkBodyPart(),
                specialBirthMarkBodyPartPositions=await extendedMasterDataService.GetAllSpecialBirthMarkBodyPartPosition()
            };
            return model;
        }

        // GET: api/ExtendMaster/GetDressInformationMasterData
        [HttpGet]
        public async Task<MDDressInformationModel> GetDressInformationMasterData()
        {
            MDDressInformationModel model = new MDDressInformationModel
            {
                inTheBodies = await extendedMasterDataService.GetAllInTheBody(),
                inTheHeads = await extendedMasterDataService.GetAllInTheHead(),
                inTheLegs = await extendedMasterDataService.GetAllInTheLegs(),
                inTheThroats = await extendedMasterDataService.GetAllInTheThroat(),
                inTheEyes = await extendedMasterDataService.GetAllInTheEye(),
                inTheWaists = await extendedMasterDataService.GetAllInTheWaist(),
            };
            return model;
        }

       

    }
}