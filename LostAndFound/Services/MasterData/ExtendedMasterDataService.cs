using LostAndFound.Data;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.MasterData
{
    public class ExtendedMasterDataService: IExtendedMasterDataService
    {
        private readonly LAFDbContext _context;

        public ExtendedMasterDataService(LAFDbContext context)
        {
            _context = context;
        }

        #region Lost And Found Type
        public async Task<int> SaveAddressSourceType(AddressSourceType addressSourceType)
        {
            if (addressSourceType.Id != 0)
            {
                _context.AddressSourceTypes.Update(addressSourceType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.AddressSourceTypes.AddAsync(addressSourceType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<AddressSourceType>> GetAllAddressSourceType()
        {
            return await _context.AddressSourceTypes.ToListAsync();
        }
        public async Task<int> DeleteAddressSourceTypeById(int id)
        {
            _context.AddressSourceTypes.Remove(_context.AddressSourceTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region BeardType
        public async Task<int> SaveBeardType(BeardType beardType)
        {
            if (beardType.Id != 0)
            {
                _context.BeardTypes.Update(beardType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.BeardTypes.AddAsync(beardType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<BeardType>> GetAllBeardType()
        {
            return await _context.BeardTypes.ToListAsync();
        }
        public async Task<int> DeleteBeardTypeById(int id)
        {
            _context.BeardTypes.Remove(_context.BeardTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region BodyChinType
        public async Task<int> SaveBodyChinType(BodyChinType bodyChinType)
        {
            if (bodyChinType.Id != 0)
            {
                _context.BodyChinTypes.Update(bodyChinType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.BodyChinTypes.AddAsync(bodyChinType);

                await _context.SaveChangesAsync();

                return 1;
            }

        }
        public async Task<IEnumerable<BodyChinType>> GetAllBodyChinType()
        {
            return await _context.BodyChinTypes.ToListAsync();
        }
        public async Task<int> DeleteBodyChinTypeById(int id)
        {
            _context.BodyChinTypes.Remove(_context.BodyChinTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region BodyColor
        public async Task<int> SaveBodyColor(BodyColor bodyColor)
        {
            if (bodyColor.Id != 0)
            {
                _context.BodyColors.Update(bodyColor);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.BodyColors.AddAsync(bodyColor);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<BodyColor>> GetAllBodyColor()
        {
            return await _context.BodyColors.ToListAsync();
        }
        public async Task<int> DeleteBodyColorById(int id)
        {
            _context.BodyColors.Remove(_context.BodyColors.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region BodyStructure
        public async Task<int> SaveBodyStructure(BodyStructure bodyStructure)
        {
            if (bodyStructure.Id != 0)
            {
                _context.BodyStructures.Update(bodyStructure);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.BodyStructures.AddAsync(bodyStructure);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<BodyStructure>> GetAllBodyStructure()
        {
            return await _context.BodyStructures.ToListAsync();
        }
        public async Task<int> DeleteBodyStructureById(int id)
        {
            _context.BodyStructures.Remove(_context.BodyStructures.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region CareType
        public async Task<int> SaveCareType(CareType careType)
        {
            if (careType.Id != 0)
            {
                _context.CareTypes.Update(careType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.CareTypes.AddAsync(careType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<CareType>> GetAllCareType()
        {
            return await _context.CareTypes.ToListAsync();
        }
        public async Task<int> DeleteCareTypeById(int id)
        {
            _context.CareTypes.Remove(_context.CareTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Complextion
        public async Task<int> SaveComplextion(Complextion complextion)
        {
            if (complextion.Id != 0)
            {
                _context.Complextions.Update(complextion);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.Complextions.AddAsync(complextion);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<Complextion>> GetAllComplextion()
        {
            return await _context.Complextions.ToListAsync();
        }
        public async Task<int> DeleteComplextionById(int id)
        {
            _context.Complextions.Remove(_context.Complextions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region DeadbodyCondition
        public async Task<int> SaveDeadbodyCondition(DeadbodyCondition deadbodyCondition)
        {
            if (deadbodyCondition.Id != 0)
            {
                _context.DeadbodyConditions.Update(deadbodyCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.DeadbodyConditions.AddAsync(deadbodyCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<DeadbodyCondition>> GetAllDeadbodyCondition()
        {
            return await _context.DeadbodyConditions.ToListAsync();
        }
        public async Task<int> DeleteDeadbodyConditionById(int id)
        {
            _context.DeadbodyConditions.Remove(_context.DeadbodyConditions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region DeathType
        public async Task<int> SaveDeathType(DeathType deathType)
        {
            if (deathType.Id != 0)
            {
                _context.DeathTypes.Update(deathType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.DeathTypes.AddAsync(deathType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<DeathType>> GetAllDeathType()
        {
            return await _context.DeathTypes.ToListAsync();
        }
        public async Task<int> DeleteDeathTypeById(int id)
        {
            _context.DeathTypes.Remove(_context.DeathTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region AgePeriods
        public async Task<int> SaveAgePeriod(AgePeriod agePeriod)
        {
            if (agePeriod.Id != 0)
            {
                _context.AgePeriods.Update(agePeriod);
                await _context.SaveChangesAsync();
                return 1;
            }
            else
            {
                await _context.AgePeriods.AddAsync(agePeriod);
                await _context.SaveChangesAsync();
                return 1;
            }
        }
        public async Task<IEnumerable<AgePeriod>> GetAllAgePeriod()
        {
            return await _context.AgePeriods.ToListAsync();
        }
        public async Task<int> DeleteAgePeriodById(int id)
        {
            _context.AgePeriods.Remove(_context.AgePeriods.Find(id));
            await _context.SaveChangesAsync();
            return 1;
        }
        #endregion

        #region EarType
        public async Task<int> SaveEarType(EarType earType)
        {
            if (earType.Id != 0)
            {
                _context.EarTypes.Update(earType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.EarTypes.AddAsync(earType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<EarType>> GetAllEarType()
        {
            return await _context.EarTypes.ToListAsync();
        }
        public async Task<int> DeleteEarTypeById(int id)
        {
            _context.EarTypes.Remove(_context.EarTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region EyeType
        public async Task<int> SaveEyeType(EyeType eyeType)
        {
            if (eyeType.Id != 0)
            {
                _context.EyeTypes.Update(eyeType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.EyeTypes.AddAsync(eyeType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<EyeType>> GetAllEyeType()
        {
            return await _context.EyeTypes.ToListAsync();
        }
        public async Task<int> DeleteEyeTypeById(int id)
        {
            _context.EyeTypes.Remove(_context.EyeTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region FaceShapeType
        public async Task<int> SaveFaceShapeType(FaceShapeType faceShapeType)
        {
            if (faceShapeType.Id != 0)
            {
                _context.FaceShapeTypes.Update(faceShapeType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.FaceShapeTypes.AddAsync(faceShapeType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<FaceShapeType>> GetAllFaceShapeType()
        {
            return await _context.FaceShapeTypes.ToListAsync();
        }
        public async Task<int> DeleteFaceShapeTypeById(int id)
        {
            _context.FaceShapeTypes.Remove(_context.FaceShapeTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region ForeHeadType
        public async Task<int> SaveForeHeadType(ForeHeadType foreHeadType)
        {
            if (foreHeadType.Id != 0)
            {
                _context.ForeHeadTypes.Update(foreHeadType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.ForeHeadTypes.AddAsync(foreHeadType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<ForeHeadType>> GetAllForeHeadType()
        {
            return await _context.ForeHeadTypes.ToListAsync();
        }
        public async Task<int> DeleteForeHeadTypeById(int id)
        {
            _context.ForeHeadTypes.Remove(_context.ForeHeadTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region HairType
        public async Task<int> SaveHairType(HairType hairType)
        {
            if (hairType.Id != 0)
            {
                _context.HairTypes.Update(hairType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.HairTypes.AddAsync(hairType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<HairType>> GetAllHairType()
        {
            return await _context.HairTypes.ToListAsync();
        }
        public async Task<int> DeleteHairTypeById(int id)
        {
            _context.HairTypes.Remove(_context.HairTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region HeadType
        public async Task<int> SaveHeadType(HeadType headType)
        {
            if (headType.Id != 0)
            {
                _context.HeadTypes.Update(headType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.HeadTypes.AddAsync(headType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<HeadType>> GetAllHeadType()
        {
            return await _context.HeadTypes.ToListAsync();
        }
        public async Task<int> DeleteHeadTypeById(int id)
        {
            _context.HeadTypes.Remove(_context.HeadTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheBody
        public async Task<int> SaveInTheBody(InTheBody inTheBody)
        {
            if (inTheBody.Id != 0)
            {
                _context.InTheBodies.Update(inTheBody);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheBodies.AddAsync(inTheBody);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheBody>> GetAllInTheBody()
        {
            return await _context.InTheBodies.ToListAsync();
        }
        public async Task<int> DeleteInTheBodyById(int id)
        {
            _context.InTheBodies.Remove(_context.InTheBodies.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheHead
        public async Task<int> SaveInTheHead(InTheHead inTheHead)
        {
            if (inTheHead.Id != 0)
            {
                _context.InTheHeads.Update(inTheHead);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheHeads.AddAsync(inTheHead);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheHead>> GetAllInTheHead()
        {
            return await _context.InTheHeads.ToListAsync();
        }
        public async Task<int> DeleteInTheHeadById(int id)
        {
            _context.InTheHeads.Remove(_context.InTheHeads.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheEye
        public async Task<int> SaveInTheHead(InTheEye inTheEye)
        {
            if (inTheEye.Id != 0)
            {
                _context.InTheEyes.Update(inTheEye);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheEyes.AddAsync(inTheEye);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheEye>> GetAllInTheEye()
        {
            return await _context.InTheEyes.ToListAsync();
        }
        public async Task<int> DeleteInTheEyeById(int id)
        {
            _context.InTheEyes.Remove(_context.InTheEyes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheLegs
        public async Task<int> SaveInTheLegs(InTheLegs inTheLegs)
        {
            if (inTheLegs.Id != 0)
            {
                _context.InTheLegs.Update(inTheLegs);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheLegs.AddAsync(inTheLegs);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheLegs>> GetAllInTheLegs()
        {
            return await _context.InTheLegs.ToListAsync();
        }
        public async Task<int> DeleteInTheLegsById(int id)
        {
            _context.InTheLegs.Remove(_context.InTheLegs.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheThroat
        public async Task<int> SaveInTheThroat(InTheThroat inTheThroat)
        {
            if (inTheThroat.Id != 0)
            {
                _context.InTheThroats.Update(inTheThroat);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheThroats.AddAsync(inTheThroat);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheThroat>> GetAllInTheThroat()
        {
            return await _context.InTheThroats.ToListAsync();
        }
        public async Task<int> DeleteInTheThroatById(int id)
        {
            _context.InTheThroats.Remove(_context.InTheThroats.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region InTheWaist
        public async Task<int> SaveInTheWaist(InTheWaist  inTheWaist)
        {
            if (inTheWaist.Id != 0)
            {
                _context.InTheWaists.Update(inTheWaist);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.InTheWaists.AddAsync(inTheWaist);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<InTheWaist>> GetAllInTheWaist()
        {
            return await _context.InTheWaists.ToListAsync();
        }
        public async Task<int> DeleteInTheWaistById(int id)
        {
            _context.InTheWaists.Remove(_context.InTheWaists.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MaritalStatus
        public async Task<int> SaveMaritalStatus(MaritalStatus maritalStatus)
        {
            if (maritalStatus.Id != 0)
            {
                _context.MaritalStatuses.Update(maritalStatus);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MaritalStatuses.AddAsync(maritalStatus);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<MaritalStatus>> GetAllMaritalStatus()
        {
            return await _context.MaritalStatuses.ToListAsync();
        }
        public async Task<int> DeleteMaritalStatusById(int id)
        {
            _context.MaritalStatuses.Remove(_context.MaritalStatuses.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MeasurementType
        public async Task<int> SaveMeasurementType(MeasurementType measurementType)
        {
            if (measurementType.Id != 0)
            {
                _context.MeasurementTypes.Update(measurementType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MeasurementTypes.AddAsync(measurementType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<MeasurementType>> GetAllMeasurementType()
        {
            return await _context.MeasurementTypes.ToListAsync();
        }
        public async Task<int> DeleteMeasurementTypeById(int id)
        {
            _context.MeasurementTypes.Remove(_context.MeasurementTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MeterialCondition
        public async Task<int> SaveMeterialCondition(MeterialCondition meterialCondition)
        {
            if (meterialCondition.Id != 0)
            {
                _context.MeterialConditions.Update(meterialCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MeterialConditions.AddAsync(meterialCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<MeterialCondition>> GetAllMeterialCondition()
        {
            return await _context.MeterialConditions.ToListAsync();
        }
        public async Task<int> DeleteMeterialConditionById(int id)
        {
            _context.MeterialConditions.Remove(_context.MeterialConditions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MoustacheType
        public async Task<int> SaveMoustacheType(MoustacheType moustacheType)
        {
            if (moustacheType.Id != 0)
            {
                _context.MoustacheTypes.Update(moustacheType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MoustacheTypes.AddAsync(moustacheType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<MoustacheType>> GetAllMoustacheType()
        {
            return await _context.MoustacheTypes.ToListAsync();
        }
        public async Task<int> DeleteMoustacheTypeById(int id)
        {
            _context.MoustacheTypes.Remove(_context.MoustacheTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region MouthType
        public async Task<int> SaveMouthType(MouthType mouthType)
        {
            if (mouthType.Id != 0)
            {
                _context.MouthTypes.Update(mouthType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.MouthTypes.AddAsync(mouthType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<MouthType>> GetAllMouthType()
        {
            return await _context.MouthTypes.ToListAsync();
        }
        public async Task<int> DeleteMouthTypeById(int id)
        {
            _context.MouthTypes.Remove(_context.MouthTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region NeckType
        public async Task<int> SaveNeckType(NeckType neckType)
        {
            if (neckType.Id != 0)
            {
                _context.NeckTypes.Update(neckType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.NeckTypes.AddAsync(neckType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<NeckType>> GetAllNeckType()
        {
            return await _context.NeckTypes.ToListAsync();
        }
        public async Task<int> DeleteNeckTypeById(int id)
        {
            _context.NeckTypes.Remove(_context.NeckTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region NeckType
        public async Task<int> SaveNoseType(NoseType  noseType)
        {
            if (noseType.Id != 0)
            {
                _context.NoseTypes.Update(noseType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.NoseTypes.AddAsync(noseType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<NoseType>> GetAllNoseType()
        {
            return await _context.NoseTypes.ToListAsync();
        }
        public async Task<int> DeleteNoseTypeById(int id)
        {
            _context.NoseTypes.Remove(_context.NoseTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region NumberType
        public async Task<int> SaveNumberType(NumberType numberType)
        {
            if (numberType.Id != 0)
            {
                _context.NumberTypes.Update(numberType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.NumberTypes.AddAsync(numberType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<NumberType>> GetAllNumberType()
        {
            return await _context.NumberTypes.ToListAsync();
        }
        public async Task<int> DeleteNumberTypeById(int id)
        {
            _context.NumberTypes.Remove(_context.NumberTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region PurposeOfVisite
        public async Task<int> SavePurposeOfVisite(PurposeOfVisite purposeOfVisite)
        {
            if (purposeOfVisite.Id != 0)
            {
                _context.PurposeOfVisites.Update(purposeOfVisite);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.PurposeOfVisites.AddAsync(purposeOfVisite);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<PurposeOfVisite>> GetAllPurposeOfVisite()
        {
            return await _context.PurposeOfVisites.ToListAsync();
        }
        public async Task<int> DeletePurposeOfVisiteById(int id)
        {
            _context.PurposeOfVisites.Remove(_context.PurposeOfVisites.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Religion
        public async Task<int> SaveReligion(Religion religion)
        {
            if (religion.Id != 0)
            {
                _context.Religions.Update(religion);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.Religions.AddAsync(religion);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<Religion>> GetAllReligion()
        {
            return await _context.Religions.ToListAsync();
        }
        public async Task<int> DeleteReligionById(int id)
        {
            _context.Religions.Remove(_context.Religions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region ReligionCust
        public async Task<int> SaveReligionCust(ReligionCust  religionCust)
        {
            if (religionCust.Id != 0)
            {
                _context.ReligionCusts.Update(religionCust);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.ReligionCusts.AddAsync(religionCust);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<ReligionCust>> GetAllReligionCust()
        {
            return await _context.ReligionCusts.Include(x=>x.religion).ToListAsync();
        }
        public async Task<IEnumerable<ReligionCust>> GetAllReligionCustByReligionId(int id)
        {
            return await _context.ReligionCusts.Where(x=>x.religionId==id).ToListAsync();
        }
        public async Task<int> DeleteReligionCustById(int id)
        {
            _context.ReligionCusts.Remove(_context.ReligionCusts.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region SpecialBodyCondition
        public async Task<int> SaveSpecialBodyCondition(SpecialBodyCondition specialBodyCondition)
        {
            if (specialBodyCondition.Id != 0)
            {
                _context.SpecialBodyConditions.Update(specialBodyCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.SpecialBodyConditions.AddAsync(specialBodyCondition);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<SpecialBodyCondition>> GetAllSpecialBodyCondition()
        {
            return await _context.SpecialBodyConditions.ToListAsync();
        }
        public async Task<int> DeleteSpecialBodyConditionById(int id)
        {
            _context.SpecialBodyConditions.Remove(_context.SpecialBodyConditions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region TeethType
        public async Task<int> SaveTeethType(TeethType  teethType)
        {
            if (teethType.Id != 0)
            {
                _context.TeethTypes.Update(teethType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.TeethTypes.AddAsync(teethType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<TeethType>> GetAllTeethType()
        {
            return await _context.TeethTypes.ToListAsync();
        }
        public async Task<int> DeleteTeethTypeById(int id)
        {
            _context.TeethTypes.Remove(_context.TeethTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Relation Type
        public async Task<int> SaveRelationType(RelationType relationType)
        {
            if (relationType.Id != 0)
            {
                _context.RelationTypes.Update(relationType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.RelationTypes.AddAsync(relationType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<RelationType>> GetAllRelationType()
        {
            return await _context.RelationTypes.ToListAsync();
        }
        public async Task<int> DeleteRelationTypeById(int id)
        {
            _context.RelationTypes.Remove(_context.RelationTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Habit
        public async Task<int> SaveHabit(Habit habit)
        {
            if (habit.Id != 0)
            {
                _context.Habits.Update(habit);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.Habits.AddAsync(habit);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<Habit>> GetAllHabit()
        {
            return await _context.Habits.ToListAsync();
        }
        public async Task<int> DeleteHabitById(int id)
        {
            _context.RelationTypes.Remove(_context.RelationTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Relation Type
        public async Task<int> SaveSpeech(Speech speech)
        {
            if (speech.Id != 0)
            {
                _context.Speeches.Update(speech);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.Speeches.AddAsync(speech);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<Speech>> GetAllSpeech()
        {
            return await _context.Speeches.ToListAsync();
        }
        public async Task<int> DeleteSpeechById(int id)
        {
            _context.Speeches.Remove(_context.Speeches.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Special Birth Mark Type
        public async Task<int> SaveSpecialBirthMarkType(SpecialBirthMarkType specialBirthMarkType)
        {
            if (specialBirthMarkType.Id != 0)
            {
                _context.SpecialBirthMarkTypes.Update(specialBirthMarkType);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.SpecialBirthMarkTypes.AddAsync(specialBirthMarkType);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<SpecialBirthMarkType>> GetAllSpecialBirthMarkType()
        {
            return await _context.SpecialBirthMarkTypes.ToListAsync();
        }
        public async Task<int> DeleteSpecialBirthMarkTypeById(int id)
        {
            _context.SpecialBirthMarkTypes.Remove(_context.SpecialBirthMarkTypes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Special Birth Mark Body Part
        public async Task<int> SaveSpecialBirthMarkBodyPart(SpecialBirthMarkBodyPart specialBirthMarkBodyPart)
        {
            if (specialBirthMarkBodyPart.Id != 0)
            {
                _context.SpecialBirthMarkBodyParts.Update(specialBirthMarkBodyPart);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.SpecialBirthMarkBodyParts.AddAsync(specialBirthMarkBodyPart);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<SpecialBirthMarkBodyPart>> GetAllSpecialBirthMarkBodyPart()
        {
            return await _context.SpecialBirthMarkBodyParts.ToListAsync();
        }
        public async Task<int> DeleteSpecialBirthMarkBodyPartById(int id)
        {
            _context.SpecialBirthMarkBodyParts.Remove(_context.SpecialBirthMarkBodyParts.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion

        #region Special Birth Mark Body Part Position
        public async Task<int> SaveSpecialBirthMarkBodyPartPosition(SpecialBirthMarkBodyPartPosition specialBirthMarkBodyPartPosition)
        {
            if (specialBirthMarkBodyPartPosition.Id != 0)
            {
                _context.SpecialBirthMarkBodyPartPositions.Update(specialBirthMarkBodyPartPosition);

                await _context.SaveChangesAsync();

                return 1;
            }
            else
            {
                await _context.SpecialBirthMarkBodyPartPositions.AddAsync(specialBirthMarkBodyPartPosition);

                await _context.SaveChangesAsync();

                return 1;
            }
        }
        public async Task<IEnumerable<SpecialBirthMarkBodyPartPosition>> GetAllSpecialBirthMarkBodyPartPosition()
        {
            return await _context.SpecialBirthMarkBodyPartPositions.ToListAsync();
        }
        public async Task<int> DeleteSpecialBirthMarkBodyPartPositionById(int id)
        {
            _context.SpecialBirthMarkBodyPartPositions.Remove(_context.SpecialBirthMarkBodyPartPositions.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }
        #endregion


    }
}
