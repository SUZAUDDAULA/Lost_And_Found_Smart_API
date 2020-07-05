using LostAndFound.Api.Models;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Areas.ReportORApplication.Models;
using LostAndFound.Data;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Services.LostFoundServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LostAndFound.Services.LostFoundServices
{
    public class LostAndFoundService: ILostAndFoundService
    {
        private readonly LAFDbContext _context;

        public LostAndFoundService(LAFDbContext context)
        {
            _context = context;
        }

        #region GD Information
        public async Task<int> SaveGDInformation(GDInformation gDInformation)
        {
            if (gDInformation.Id != 0)
            {
                _context.GDInformation.Update(gDInformation);

                await _context.SaveChangesAsync();

                return gDInformation.Id;
            }
            else
            {
                await _context.GDInformation.AddAsync(gDInformation);

                await _context.SaveChangesAsync();

                return gDInformation.Id;
            }

        }

        public async Task<IEnumerable<GDInformation>> GetAllGDInformation()
        {
            return await _context.GDInformation.ToListAsync();
        }

        public StatusTypeViewModel GetCountGDInformationStatus(string userId)
        {
            int? complain = _context.GDInformation.Where(x => x.statusId == 1 && x.ApplicationUserId==userId).Count();
            int? investigation = _context.GDInformation.Where(x => x.statusId == 2 && x.ApplicationUserId == userId).Count();
            int? finish = _context.GDInformation.Where(x => x.statusId == 3 && x.ApplicationUserId == userId).Count();
            int? reject = _context.GDInformation.Where(x => x.statusId == 4 && x.ApplicationUserId == userId).Count();

            StatusTypeViewModel model = new StatusTypeViewModel
            {
                complain=complain,
                investigation=investigation,
                finish=finish,
                reject=reject
            };
            return model;
        }

        public GDTypeStatusModel GetCountGDInformationByGDType(string userId,int statusId)
        {
            int? lost = _context.GDInformation.Where(x => x.statusId == statusId && x.gDTypeId==1 && x.ApplicationUserId==userId).Count();
            int? found = _context.GDInformation.Where(x => x.statusId == statusId && x.gDTypeId==2 && x.ApplicationUserId == userId).Count();
            int? theft = _context.GDInformation.Where(x => x.statusId == statusId && x.gDTypeId == 3 && x.ApplicationUserId == userId).Count();

            GDTypeStatusModel model = new GDTypeStatusModel
            {
                lostCnt=lost,
                foundCnt=found,
                theftCnt=theft
            };
            return model;
        }

        public async Task<IEnumerable<GDInformation>> GetAllGDInformationByFiltering(int statusId, int gdTypeId,string userId)
        {
            var result =await (from g in _context.GDInformation
                         where g.gDTypeId == (gdTypeId == 0 ? g.gDTypeId : gdTypeId) && g.statusId == (statusId == 0 ? g.statusId : statusId)
                         && g.ApplicationUserId==(userId== "5eeaabd4-0abc-4836-aa58-e1de72a626a8"?g.ApplicationUserId:userId)
                         select new GDInformation
                         {
                             Id=g.Id,
                             gdFor=g.gdFor,
                             productTypeId=g.productTypeId,
                             gDTypeId=g.gDTypeId,
                             documentTypeId=g.documentTypeId,
                             gdNumber=g.gdNumber,
                             gdDate=g.gdDate,
                             date=Convert.ToDateTime(g.gdDate).ToString("dd-MM-yyyy"),
                             statusId=g.statusId,
                             status= g.statusId == 1 ? "Allegation" : g.statusId == 2 ? "Investigation":g.statusId==3?"Disposal" : "Cancel"
                         }).ToListAsync();
            return result;
            //return await _context.GDInformation.Where(x => x.gDTypeId == (gdTypeId == 0 ? x.gDTypeId : gdTypeId) && x.statusId == (statusId == 0 ? x.statusId : statusId)).ToListAsync();
        }

        public async Task<IEnumerable<GDInformation>> GetAllGDInformationByGDType(int statusId,int gdTypeId)
        {
            return await _context.GDInformation.Where(x=>x.gDTypeId==(gdTypeId==0?x.gDTypeId:gdTypeId) && x.statusId==(statusId==0?x.statusId:statusId)).ToListAsync();
        }

        public async Task<IEnumerable<GDInformation>> GetAllGDInformationByStatus(string userId,int statusId)
        {
            return await _context.GDInformation.Where(x => x.ApplicationUserId == userId && x.statusId==(statusId==0?x.statusId:statusId)).ToListAsync();
        }

        public async Task<IEnumerable<GDInformation>> GetAllGDInformationByUser(string userId)
        {
            return await _context.GDInformation.Include(x=>x.gDType).Include(x=>x.productType).Where(x=>x.ApplicationUserId== userId).ToListAsync();
        }

        public async Task<IEnumerable<NewsFeedViewModel>> GetALLNewFeedsInfo(string userId,int gdTypeId,int vehicleTypeId)
        {
            //TimeSpan span = (DateTime.Now - DateTime.Now);
            //string datetime = "just now";
            //if(span.Days<1 && span.Hours<1 && span.Minutes < 3)
            //{
            //    datetime = "just now";
            //}else if (span.Days < 1 && span.Hours < 1 && span.Minutes < 60 && span.Minutes>2)
            //{
            //    datetime = span.Minutes.ToString()+ " mins";
            //}
            //else if (span.Days < 1 && span.Hours < 24 && span.Minutes > 60)
            //{
            //    datetime = span.Hours.ToString()+" hours";
            //}
            //else if (span.Days == 1)
            //{
            //    datetime = "Yesterday at "+span.Hours.ToString()+":"+span.Minutes.ToString();
            //}

            var result =await (from g in _context.GDInformation
                         join v in _context.VehicleInformation on g.Id equals v.gDInformationId
                         join vt in _context.VehicleTypes on v.vehicleTypeId equals vt.Id into vtt
                         from t in vtt.DefaultIfEmpty()
                         join a in _context.AttachmentInformation on g.Id equals a.gDInformationId
                         join u in _context.Users on g.ApplicationUserId equals u.Id
                         join l in _context.Likes.Where(x=>x.statusId==1).GroupBy(x=>x.vehicleId).Select(x=>new Likes { vehicleId=x.Key,total=x.Count()}) on v.Id equals l.vehicleId into ll
                        from lk in ll.DefaultIfEmpty()
                        join c in _context.Comments.Where(x => x.statusId == 1).GroupBy(x => x.vehicleId).Select(x => new Comments { vehicleId = x.Key, total = x.Count() }) on v.Id equals c.vehicleId into cc
                        from cm in cc.DefaultIfEmpty()
                        where v.vehicleTypeId== vehicleTypeId && g.gDTypeId==gdTypeId
                        select new NewsFeedViewModel
                         {
                             userName = u.UserName,
                             fullName = u.FullName,
                             profilePic = u.ImagePath,
                             gdNumber = g.gdNumber,
                             gdDate = g.gdDate.ToString().Substring(0,16),
                             vehicleDescription = a.fileSubject,
                             vehicleTypeName = t.vehicleTypeName,
                             attachImage = a.filePath,
                             encodedImage=a.encodedImage,
                             vehicleId=v.Id,
                             attachmentId=a.Id,
                             totalLikes=lk.total,
                             totalComments=cm.total
                         }).ToListAsync();

            return result;
        }

        public async Task<GDInformation> GetGDInformationById(int gdId)
        {
            return await _context.GDInformation
                .Include(x=>x.ApplicationUser)
                .Include(x=>x.documentType)
                .Include(x=>x.gDType)
                .Include(x=>x.productType)
                .Where(x=>x.Id==gdId).FirstOrDefaultAsync();
        }

        public async Task<int> DeleteGDInformationById(int id)
        {
            _context.GDInformation.Remove(_context.GDInformation.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Identify Information
        public async Task<int> SaveIndentifyInfo(IndentifyInfo indentifyInfo)
        {
            if (indentifyInfo.Id != 0)
            {
                _context.IndentifyInfos.Update(indentifyInfo);

                await _context.SaveChangesAsync();

                return indentifyInfo.Id;
            }
            else
            {
                await _context.IndentifyInfos.AddAsync(indentifyInfo);

                await _context.SaveChangesAsync();

                return indentifyInfo.Id;
            }

        }
        
        public async Task<IndentifyInfo> GetIndentifyInfoByGDId(int gdId)
        {
            return await _context.IndentifyInfos.Include(x=>x.colors).Where(x=>x.gDInformationId==gdId).FirstOrDefaultAsync();
        }

        public async Task<int> DeleteIndentifyInfoByGDId(int gdId)
        {
            _context.IndentifyInfos.RemoveRange(_context.IndentifyInfos.Where(x=>x.gDInformationId==gdId));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Man Habit Details
        public async Task<int> SaveManHabitDetails(ManHabitDetails manHabitDetails)
        {
            if (manHabitDetails.Id != 0)
            {
                _context.ManHabitDetails.Update(manHabitDetails);

                await _context.SaveChangesAsync();

                return manHabitDetails.Id;
            }
            else
            {
                await _context.ManHabitDetails.AddAsync(manHabitDetails);

                await _context.SaveChangesAsync();

                return manHabitDetails.Id;
            }

        }

        public async Task<IEnumerable<ManHabitDetails>> GetManHabitDetailsByManId(int manId)
        {
            return await _context.ManHabitDetails.Where(x=>x.manInformationId==manId).ToListAsync();
        }

        #endregion

        #region Man Speech Details
        public async Task<int> SaveManSpeechDetails(ManSpeechDetails manSpeechDetails)
        {
            if (manSpeechDetails.Id != 0)
            {
                _context.ManSpeechDetails.Update(manSpeechDetails);

                await _context.SaveChangesAsync();

                return manSpeechDetails.Id;
            }
            else
            {
                await _context.ManSpeechDetails.AddAsync(manSpeechDetails);

                await _context.SaveChangesAsync();

                return manSpeechDetails.Id;
            }

        }

        public async Task<IEnumerable<ManSpeechDetails>> GetManSpeechDetailsByManId(int manId)
        {
            return await _context.ManSpeechDetails.Where(x => x.manInformationId == manId).ToListAsync();
        }

        #endregion

        #region DNA Profile Details
        public async Task<int> SaveDNAProfileDetails(List<DNAProfileDetails> dNAProfileDetails)
        {
            
            await _context.DNAProfileDetails.AddRangeAsync(dNAProfileDetails);

            await _context.SaveChangesAsync();

            return 1;
            
        }

        public async Task<IEnumerable<DNAProfileDetails>> GetDNAProfileDetailsByManId(int manId)
        {
            return await _context.DNAProfileDetails.Where(x => x.manInformationId == manId).ToListAsync();
        }

        #endregion

        #region Other Person Information
        public async Task<int> SaveOtherPersonInformation(OtherPersonInformation otherPersonInformation)
        {
            if (otherPersonInformation.Id != 0)
            {
                _context.OtherPersonInformation.Update(otherPersonInformation);

                await _context.SaveChangesAsync();

                return otherPersonInformation.Id;
            }
            else
            {
                await _context.OtherPersonInformation.AddAsync(otherPersonInformation);

                await _context.SaveChangesAsync();

                return otherPersonInformation.Id;
            }

        }

        public async Task<OtherPersonInformation> GetOtherPersonInformationByGDId(int gdId)
        {
            return await _context.OtherPersonInformation.Where(x=>x.gDInformationId==gdId).FirstOrDefaultAsync();
        }

        public async Task<int> DeleteOtherPersonInformationByGDId(int gdId)
        {
            _context.OtherPersonInformation.RemoveRange(_context.OtherPersonInformation.Where(x => x.gDInformationId == gdId));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Space And Time Information
        public async Task<int> SaveSpaceAndTime(SpaceAndTime spaceAndTime)
        {
            if (spaceAndTime.Id != 0)
            {
                _context.SpaceAndTimes.Update(spaceAndTime);

                await _context.SaveChangesAsync();

                return spaceAndTime.Id;
            }
            else
            {
                await _context.SpaceAndTimes.AddAsync(spaceAndTime);

                await _context.SaveChangesAsync();

                return spaceAndTime.Id;
            }

        }

        public async Task<SpaceAndTime> GetSpaceAndTimeByGDId(int gdId)
        {
            return await _context.SpaceAndTimes.Include(x=>x.division)
                .Include(x=>x.district)
                .Include(x=>x.thana)
                .Include(x=>x.postOffice)
                .Where(x => x.gDInformationId == gdId).FirstOrDefaultAsync();
        }

        public async Task<int> DeleteSpaceAndTimeByGDId(int gdId)
        {
            _context.SpaceAndTimes.RemoveRange(_context.SpaceAndTimes.Where(x => x.gDInformationId == gdId));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Vehicle Information
        public async Task<int> SaveVehicleInformation(VehicleInformation vehicleInformation)
        {
            if (vehicleInformation.Id != 0)
            {
                _context.VehicleInformation.Update(vehicleInformation);

                await _context.SaveChangesAsync();

                return vehicleInformation.Id;
            }
            else
            {
                await _context.VehicleInformation.AddAsync(vehicleInformation);

                await _context.SaveChangesAsync();

                return vehicleInformation.Id;
            }

        }

        public void UpdateGDInformationStatusById(int id, int statusId)
        {
            var gD = _context.GDInformation.Where(x => x.Id == id).FirstOrDefault();
            gD.statusId = statusId;
            _context.Entry(gD).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task<VehicleInformation> GetVehicleInformationByGDId(int gdId)
        {
            return await _context.VehicleInformation
                .Include(x=>x.vehicleType)
                .Where(x => x.gDInformationId == gdId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<string>> GetAllVehicleModelNo()
        {
            var result = await (from v in _context.VehicleInformation
                                group v by v.modelNo into vv
                                select new { modelNo = vv.Key } into vvv
                                select vvv.modelNo
                         ).AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<IEnumerable<VehicleInformation>> GetVehicleInformationBySearching(int? typeId,int? brandId,string modelNo,string regiNo,string engineNo,string chesisNo,string cc,int? colorId,string userId)
        {
            var result =await (from v in _context.VehicleInformation
                          join g in _context.GDInformation on v.gDInformationId equals g.Id
                          join t in _context.VehicleTypes on v.vehicleTypeId equals t.Id
                          join b in _context.VehicleModels on v.vehicleBrandId equals b.Id into bb
                          from vm in bb.DefaultIfEmpty()    
                          join i in _context.IndentifyInfos.Include(x => x.colors) on g.Id equals i.gDInformationId into ii
                          from idn in ii.DefaultIfEmpty()
                          join s in _context.SpaceAndTimes on g.Id equals s.gDInformationId into ss
                               from st in ss.DefaultIfEmpty()

                               where v.vehicleTypeId == (typeId == 0 ? v.vehicleTypeId : typeId)
                          && v.vehicleBrandId == (brandId == 0 ? v.vehicleBrandId : brandId)
                          && v.modelNo == (modelNo == "NA" ? v.modelNo : modelNo)
                          && v.vehicleRegNo == (regiNo == "NA" ? v.vehicleRegNo : regiNo)
                          && v.engineNo == (engineNo == "NA" ? v.engineNo : engineNo)
                          && v.chasisNo == (chesisNo == "NA" ? v.chasisNo : chesisNo)
                          && v.ccNo == (cc == "NA" ? v.ccNo : cc)
                          && idn.colorsId == (colorId == 0 ? idn.colorsId : colorId)
                          && g.ApplicationUserId==(userId== "5eeaabd4-0abc-4836-aa58-e1de72a626a8"?g.ApplicationUserId:userId)
                          && g.statusId==1
                          select new VehicleInformation
                          {
                              gDInformation = g,
                              vehicleType = t,
                              vehicleBrand = vm,
                              indentifyInfo=idn,
                              spaceAndTime=st,
                              vehicleRegNo=v.vehicleRegNo,
                              regNoFirstPart=v.regNoFirstPart,
                              regNoSecondPart=v.regNoSecondPart,
                              regNoThiredPart=v.regNoThiredPart,
                              madeBy=v.madeBy,
                              madeIn=v.madeIn,
                              mfcDate=v.mfcDate,
                              engineNo=v.engineNo,
                              chasisNo=v.chasisNo,
                              ccNo=v.ccNo
                          }).ToListAsync();
            return result;
        }

       

        //public async Task<IEnumerable<VehicleInformation>> GetVehicleInformationForDashboard(string userId)
        //{
        //    var result = await (from GI in _context.GDInformation
        //                        join GT in _context.GDTypes on GI.gDTypeId equals GT.Id
        //                        join PT in _context.ProductTypes on GI.productTypeId equals PT.Id
        //                        join VI in (from v in _context.VehicleInformation
        //                                    join vt in _context.VehicleTypes on v.vehicleTypeId equals vt.Id
        //                                    join vb in _context.VehicleModels on v.vehicleBrandId equals vb.Id
        //                                    select new { v.gDInformationId, v.vehicleTypeId,vt.vehicleTypeName,vt.vehicleTypeNameBn,v.vehicleBrandId,brandName=vb.modelName,brandNameBn=vb.modelNameBn }) on GI.Id equals VI.gDInformationId into IV
        //                                    from VII in IV.DefaultIfEmpty()

        //                        join OI in (from o in _context.OtherDocumentDetails
        //                                    join dt in _context.DocumentTypes on o.documentTypeId equals dt.Id
        //                                    select new { o.gDInformationId,o.documentTypeId,dt.documentTypeName,dt.documentTypeNameBn,o.modelName,modelNameBn=""}) on GI.Id equals OI.gDInformationId

        //                        where GI.ApplicationUserId == (userId == "5eeaabd4-0abc-4836-aa58-e1de72a626a8" ? GI.ApplicationUserId : userId)
        //                        select new VehicleInformation
        //                        {
        //                            gDInformation = g,
        //                            vehicleType = t,
        //                            vehicleBrand = vm,
        //                            indentifyInfo = idn,
        //                            spaceAndTime = st,
        //                            vehicleRegNo = v.vehicleRegNo,
        //                            regNoFirstPart = v.regNoFirstPart,
        //                            regNoSecondPart = v.regNoSecondPart,
        //                            regNoThiredPart = v.regNoThiredPart,
        //                            madeBy = v.madeBy,
        //                            madeIn = v.madeIn,
        //                            mfcDate = v.mfcDate,
        //                            engineNo = v.engineNo,
        //                            chasisNo = v.chasisNo,
        //                            ccNo = v.ccNo
        //                        }).ToListAsync();
        //    return result;
        //}

        public async Task<int> DeleteVehicleInformationByGDId(int gdId)
        {
            _context.VehicleInformation.RemoveRange(_context.VehicleInformation.Where(x => x.gDInformationId == gdId));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Man Information
        public async Task<int> SaveManInformation(ManInformation manInformation)
        {
            if (manInformation.Id != 0)
            {
                _context.ManInformation.Update(manInformation);

                await _context.SaveChangesAsync();

                return manInformation.Id;
            }
            else
            {
                await _context.ManInformation.AddAsync(manInformation);

                await _context.SaveChangesAsync();

                return manInformation.Id;
            }

        }

        public async Task<ManInformation> GetManInformationByGDId(int gdId)
        {
            var result= await _context.ManInformation
                //.Include(x => x.district)
                //.Include(x => x.country)
                .Where(x => x.gDInformationId == gdId).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<GDInformation>> GetMenInformationBySearching(GDManInformationViewModel model)
        {
            var result = await (from m in _context.ManInformation
                                join g in _context.GDInformation on m.gDInformationId equals g.Id
                                join py in _context.PhysicalDescriptions on m.Id equals py.manInformationId into pyy
                                from p in pyy.DefaultIfEmpty()
                                join gnr in _context.Genders on m.genderId equals gnr.Id into gg
                                from gr in gg.DefaultIfEmpty()
                                join ind in _context.IndentifyInfos on g.Id equals ind.gDInformationId into inn
                                from id in inn.DefaultIfEmpty()
                                join stt in _context.SpaceAndTimes on g.Id equals stt.gDInformationId into sttt
                                from st in sttt.DefaultIfEmpty()

                                join d in _context.DressDescriptions on m.Id equals d.manInformationId into ds
                                from dd in ds.DefaultIfEmpty()

                                where p.eyeTypeId == (model.eyeTypeId == null ? p.eyeTypeId : model.eyeTypeId)
                                && p.noseTypeId == (model.noseTypeId == null ? p.noseTypeId : model.noseTypeId)
                                && p.hairTypeId == (model.hairTypeId == null ? p.hairTypeId : model.hairTypeId)
                                && p.foreHeadTypeId == (model.foreHeadTypeId == null ? p.foreHeadTypeId : model.foreHeadTypeId)
                                && p.beardTypeId == (model.beardTypeId == null ? p.beardTypeId : model.beardTypeId)
                                && p.bodyStructureId == (model.bodyStructureId == null ? p.bodyStructureId : model.bodyStructureId)
                                && p.faceShapeTypeId == (model.faceShapeTypeId == null ? p.faceShapeTypeId : model.faceShapeTypeId)
                                && p.bodyChinTypeId == (model.bodyChinTypeId == null ? p.bodyChinTypeId : model.bodyChinTypeId)
                                && p.bodyColorId == (model.bodyColorId == null ? p.bodyColorId : model.bodyColorId)
                                && p.moustacheTypeId == (model.moustacheTypeId == null ? p.moustacheTypeId : model.moustacheTypeId)
                                && p.earTypeId == (model.earTypeId == null ? p.earTypeId : model.earTypeId)
                                && p.neckTypeId == (model.neckTypeId == null ? p.neckTypeId : model.neckTypeId)
                                && p.teethTypeId == (model.teethTypeId == null ? p.teethTypeId : model.teethTypeId)
                                && p.specialBodyConditionId == (model.specialBodyConditionId == null ? p.specialBodyConditionId : model.specialBodyConditionId)
                                && p.specialBirthMarkTypeId == (model.specialBirthMarkTypeId == null ? p.specialBirthMarkTypeId : model.specialBirthMarkTypeId)
                                && p.specialBirthMarkBodyPartId == (model.specialBirthMarkBodyPartId == null ? p.specialBirthMarkBodyPartId : model.specialBirthMarkBodyPartId)
                                && p.specialBirthMarkBodyPartPositionId == (model.specialBirthMarkBodyPartPositionId == null ? p.specialBirthMarkBodyPartPositionId : model.specialBirthMarkBodyPartPositionId)
                                && p.weight == (model.weight == null ? p.weight : model.weight)
                                && p.heightFeet == (model.heightFeet == null ? p.heightFeet : model.heightFeet)
                                && p.heightInch == (model.heightInch == null ? p.heightInch : model.heightInch)
                                && p.visibleTatto == (model.visibleTatto == string.Empty ? p.visibleTatto : model.visibleTatto)
                                && p.otherIdentityfyMark == (model.otherIdentityfyMark == string.Empty ? p.otherIdentityfyMark : model.otherIdentityfyMark)

                                && dd.inTheHeadId == (model.inTheHeadId == null ? dd.inTheHeadId : model.inTheHeadId)
                                && dd.inTheHeadColorId == (model.inTheHeadColorId == null ? dd.inTheHeadColorId : model.inTheHeadColorId)
                                && dd.inTheEyeId == (model.inTheEyeId == null ? dd.inTheEyeId : model.inTheEyeId)
                                && dd.inTheEyeColorId == (model.inTheEyeColorId == null ? dd.inTheEyeColorId : model.inTheEyeColorId)
                                && dd.inTheThroatId == (model.inTheThroatId == null ? dd.inTheThroatId : model.inTheThroatId)
                                && dd.inTheThroatColorId == (model.inTheThroatColorId == null ? dd.inTheThroatColorId : model.inTheThroatColorId)
                                && dd.inTheBodyId == (model.inTheBodyId == null ? dd.inTheBodyId : model.inTheBodyId)
                                && dd.inTheBodyColorId == (model.inTheBodyColorId == null ? dd.inTheBodyColorId : model.inTheBodyColorId)
                                && dd.inTheWaistId == (model.inTheWaistId == null ? dd.inTheWaistId : model.inTheWaistId)
                                && dd.inTheWaistColorId == (model.inTheWaistColorId == null ? dd.inTheWaistColorId : model.inTheWaistColorId)
                                && dd.inTheLegsId == (model.inTheLegsId == null ? dd.inTheLegsId : model.inTheLegsId)
                                && dd.inTheLegsColorId == (model.inTheLegsColorId == null ? dd.inTheLegsColorId : model.inTheLegsColorId)
                                && dd.shoesSize == (model.shoesSize == null ? dd.shoesSize : model.shoesSize)
                                && dd.shoesSizeType == (model.shoesSizeType == string.Empty ? dd.shoesSizeType : model.shoesSizeType)
                                //&& g.Id==model.gDInformationId
                                //g.ApplicationUserId == (userId == "5eeaabd4-0abc-4836-aa58-e1de72a626a8" ? g.ApplicationUserId : userId)
                                //&& g.statusId == 1
                                select new GDInformation
                                {
                                    Id = g.Id,
                                    gdFor = g.gdFor,
                                    productTypeId = g.productTypeId,
                                    gDTypeId = g.gDTypeId,
                                    documentTypeId = g.documentTypeId,
                                    gdNumber = g.gdNumber,
                                    gdDate = g.gdDate,
                                    date = Convert.ToDateTime(g.gdDate).ToString("dd-MM-yyyy"),
                                    statusId = g.statusId,
                                    status = g.statusId == 1 ? "Allegation" : g.statusId == 2 ? "Investigation" : g.statusId == 3 ? "Disposal" : "Cancel"
                                }).ToListAsync();
            return result;
        }

        public async Task<int> DeleteManInformationByGDId(int gdId)
        {
            _context.ManInformation.RemoveRange(_context.ManInformation.Where(x => x.gDInformationId == gdId));

            await _context.SaveChangesAsync();

            return 1;
        }

        #endregion

        #region Physical Information
        public async Task<int> SavePhysicalDescription(PhysicalDescription physicalDescription)
        {
            if (physicalDescription.Id != 0)
            {
                _context.PhysicalDescriptions.Update(physicalDescription);

                await _context.SaveChangesAsync();

                return physicalDescription.Id;
            }
            else
            {
                await _context.PhysicalDescriptions.AddAsync(physicalDescription);

                await _context.SaveChangesAsync();

                return physicalDescription.Id;
            }

        }



        #endregion

        #region Dress Information
        public async Task<int> SaveDressDescription(DressDescription dressDescription)
        {
            if (dressDescription.Id != 0)
            {
                _context.DressDescriptions.Update(dressDescription);

                await _context.SaveChangesAsync();

                return dressDescription.Id;
            }
            else
            {
                await _context.DressDescriptions.AddAsync(dressDescription);

                await _context.SaveChangesAsync();

                return dressDescription.Id;
            }

        }



        #endregion

        #region Attachment Information
        public async Task<int> SaveAttachmentInformation(AttachmentInformation attachment)
        {
            if (attachment.Id != 0)
            {
                _context.AttachmentInformation.Update(attachment);

                await _context.SaveChangesAsync();

                return attachment.Id;
            }
            else
            {
                await _context.AttachmentInformation.AddAsync(attachment);

                await _context.SaveChangesAsync();

                return attachment.Id;
            }

        }



        #endregion

        #region Likes
        public async Task<int> SaveLikes(Likes likes)
        {
            if (likes.Id != 0)
            {
                var LikeInfo = _context.Likes.Where(x => x.ApplicationUserId == likes.ApplicationUserId && x.vehicleId == likes.vehicleId).FirstOrDefaultAsync();
                _context.Entry(LikeInfo).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return likes.Id;
            }
            else
            {
                await _context.Likes.AddAsync(likes);

                await _context.SaveChangesAsync();

                return likes.Id;
            }

        }
        public async Task<IEnumerable<Likes>> GetAllLikes()
        {
            return await _context.Likes
                .Include(x => x.ApplicationUser)
                .Include(x => x.vehicle)
                .Include(x => x.attachment).ToListAsync();
        }
        public async Task<Likes> GetLikesByUser(string userId,int vehicleId)
        {
            return await _context.Likes.Where(x=>x.ApplicationUserId==userId && x.vehicleId==vehicleId).FirstOrDefaultAsync();
        }
        public async Task<Likes> GetLikesById(int id)
        {
            return await _context.Likes
               .Include(x => x.ApplicationUser)
                .Include(x => x.vehicle)
                .Include(x => x.attachment).FirstOrDefaultAsync();
        }
        public async Task<int> DeleteLikesById(int id)
        {
            _context.Likes.Remove(_context.Likes.Find(id));

            await _context.SaveChangesAsync();

            return 1;
        }


        #endregion

        #region Comments
        public async Task<int> SaveComments(Comments comments)
        {
            if (comments.Id != 0)
            {
                _context.Comments.Update(comments);

                await _context.SaveChangesAsync();

                return comments.Id;
            }
            else
            {
                await _context.Comments.AddAsync(comments);

                await _context.SaveChangesAsync();

                return comments.Id;
            }

        }



        #endregion

    }
}
