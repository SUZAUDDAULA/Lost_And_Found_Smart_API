using LostAndFound.Api.Models;
using LostAndFound.Areas.LostFound.Models;
using LostAndFound.Areas.ReportORApplication.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Helpers;
using LostAndFound.Services.LostFoundServices.Interfaces;
using LostAndFound.Services.MasterData.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LostFoundController : ControllerBase
    {
        private readonly ILostAndFoundType lostAndFoundType;
        private readonly ILostAndFoundService lostAndFoundService;
        private readonly IOtherDocumentService otherDocumentService;
        private readonly IAddressInformationService addressInformationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public LostFoundController(ILostAndFoundType lostAndFoundType, ILostAndFoundService lostAndFoundService, UserManager<ApplicationUser> userManager, IOtherDocumentService otherDocumentService, IAddressInformationService addressInformationService)
        {
            this.lostAndFoundType = lostAndFoundType;
            this.lostAndFoundService = lostAndFoundService;
            this.otherDocumentService = otherDocumentService;
            this.addressInformationService = addressInformationService;
            _userManager = userManager;
        }

        //POST: api/LostFound/SaveGDManInformation
        
        [HttpPost]
        //[AllowAnonymous]
        public async Task<IActionResult> SaveGDManInformation([FromBody]GDManInformationViewModel model)
        {
            //return Ok("Success");
            try
            {
                var user = await _userManager.FindByNameAsync(model.userName);
                string gdNumber = RandomString(6);
                GDInformation gDInformation = new GDInformation
                {
                    ApplicationUserId = user.Id,
                    gdFor = model.gdFor,
                    gdDate = DateTime.Now,
                    gdNumber = gdNumber,
                    gDTypeId = model.gDTypeId,
                    productTypeId = model.productTypeId,
                    documentTypeId = model.documentTypeId == 0 ? null : model.documentTypeId,
                    documentDescription = model.documentDescription,
                    statusId = 1
                };

                int gdId = await lostAndFoundService.SaveGDInformation(gDInformation);


                ManInformation manInformation = new ManInformation
                {
                    gDInformationId = gdId,
                    relationTypeId = model.relationTypeId,
                    name = model.name,
                    aproxAge = model.aproxAge,
                    agePeriodId = model.agePeriodId,
                    genderId = model.genderId,
                    isHealthDisabled = model.isHealthDisabled,
                    fatherName = model.fatherName,
                    motherName = model.motherName,
                    spouseName = model.spouseName,
                    nationalIdentityTypeId = model.manNationalIdentityTypeId,
                    identityNo = model.identityNo,
                    numberTypeId = model.numberTypeId,
                    number = model.number
                };

                int manid = await lostAndFoundService.SaveManInformation(manInformation);

                if (model.gdFor == "OTHERS")
                {
                    OtherPersonInformation otherPerson = new OtherPersonInformation
                    {
                        gDInformationId = gdId,
                        nationalIdentityTypeId = model.nationalIdentityTypeId == 0 ? null : model.nationalIdentityTypeId,
                        identityNo = model.identityNo,
                        mobileNo = model.mobileNo
                    };
                    int opi = await lostAndFoundService.SaveOtherPersonInformation(otherPerson);
                }

                IndentifyInfo indentifyInfo = new IndentifyInfo
                {
                    gDInformationId = gdId,
                    colorsId = model.colorsId,
                    identifySign = model.identifySign,
                    descriptionCircumcisionId = model.descriptionCircumcisionId,
                    religionId = model.religionId,
                    bloodGroup = model.bloodGroup,
                    occupationId = model.occupationId,
                    maritalStatusId = model.maritalStatusId
                };
                int identityid = await lostAndFoundService.SaveIndentifyInfo(indentifyInfo);

                AddressInformation addressInformation = new AddressInformation
                {
                    districtId = model.manDistrictId,
                    thanaId = model.thanaId,
                    houseVillage = model.postOffice,
                    addressDetails = model.addressDetails,
                    type = model.addressType,
                    oneLineAddress = model.oneLineAddress,
                };
                int addressId = await addressInformationService.SaveAddressInformation(addressInformation);

                PhysicalDescription physical = new PhysicalDescription
                {
                    manInformationId = manid,
                    eyeTypeId = model.eyeTypeId,
                    noseTypeId = model.noseTypeId,
                    hairTypeId = model.hairTypeId,
                    foreHeadTypeId = model.foreHeadTypeId,
                    beardTypeId = model.beardTypeId,
                    weight = model.weight,
                    bodyStructureId = model.bodyStructureId,
                    faceShapeTypeId = model.faceShapeTypeId,
                    bodyChinTypeId = model.bodyChinTypeId,
                    bodyColorId = model.bodyColorId,
                    moustacheTypeId = model.moustacheTypeId,
                    earTypeId = model.earTypeId,
                    neckTypeId = model.neckTypeId,
                    heightFeet = model.heightFeet,
                    heightInch = model.heightInch,
                    specialBirthMarkTypeId = model.specialBirthMarkTypeId,
                    specialBirthMarkBodyPartId = model.specialBirthMarkBodyPartId,
                    specialBirthMarkBodyPartPositionId = model.specialBirthMarkBodyPartPositionId,
                    visibleTatto = model.visibleTatto,
                    otherIdentityfyMark = model.otherIdentityfyMark,
                    teethTypeId = model.teethTypeId,
                    specialBodyConditionId = model.specialBodyConditionId,

                };
                int phyId = await lostAndFoundService.SavePhysicalDescription(physical);

                DressDescription dress = new DressDescription
                {
                    manInformationId = manid,
                    inTheHeadId = model.inTheHeadId,
                    inTheHeadColorId = model.inTheHeadColorId,
                    inTheBodyId = model.inTheBodyId,
                    inTheBodyColorId = model.inTheBodyColorId,
                    inTheThroatId = model.inTheThroatId,
                    inTheThroatColorId = model.inTheThroatColorId,
                    inTheWaistId = model.inTheWaistId,
                    inTheWaistColorId = model.inTheWaistColorId,
                    inTheLegsId = model.inTheLegsId,
                    inTheLegsColorId = model.inTheLegsColorId,
                    inTheEyeId = model.inTheEyeId,
                    inTheEyeColorId = model.inTheEyeColorId,
                    shoesSize = model.shoesSize,
                    shoesSizeType = model.shoesSizeType,

                };
                int dressId = await lostAndFoundService.SaveDressDescription(dress);
                SpaceAndTime spaceAndTime = new SpaceAndTime
                {
                    gDInformationId = gdId,
                    placeDetails = model.placeDetails,
                    lafDate = model.lafDate,
                    lafTime = model.lafTime,
                    postOfficeId = model.postOfficeId,
                    thanaId = model.thanaId,
                    districtId = model.districtId,
                    divisionId = model.divisionId
                };
                int sdid = await lostAndFoundService.SaveSpaceAndTime(spaceAndTime);

                
                if (model.dNAProfileViewModels!=null)
                {
                    List<DNAProfileDetails> lstDNAProfile = new List<DNAProfileDetails>();
                    foreach (var item in model.dNAProfileViewModels)
                    {
                        DNAProfileDetails dNAProfileDetails = new DNAProfileDetails
                        {
                            manInformationId = manid,
                            locous = item.locous,
                            genotype1 = item.genotype1,
                            genotype2 = item.genotype2
                        };
                        lstDNAProfile.Add(dNAProfileDetails);
                    }

                    int dnaId = await lostAndFoundService.SaveDNAProfileDetails(lstDNAProfile);
                }

                return Ok(gdNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //POST: api/LostFound/SaveGDInformation
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SaveVehicleWithImage(GDViewModel model)
        {

            try
            {
                var user = await _userManager.FindByNameAsync(model.userName);
                string gdNumber = RandomString(6);
                GDInformation gDInformation = new GDInformation
                {
                    ApplicationUserId = user.Id,
                    gdFor = "Own",
                    gdDate = DateTime.Now,
                    gdNumber = gdNumber,
                    gDTypeId = model.gdTypeId,
                    productTypeId = 1,
                    //documentTypeId = model.documentTypeId == 0 ? null : model.documentTypeId,
                    //documentDescription = model.documentDescription,
                    statusId = 1
                };

                int gdId = await lostAndFoundService.SaveGDInformation(gDInformation);
                VehicleInformation vehicleInformation = new VehicleInformation
                {
                    gDInformationId = gdId,
                    vehicleTypeId = model.vehicleTypeId,
                    vehicleBrandId=model.vehicleBrandId,
                    vehicleRegNo = model.regNoFirstPart+" "+ model.regNoSecondPart + " "+ model.regNoThiredPart,
                    regNoFirstPart = model.regNoFirstPart,
                    regNoSecondPart = model.regNoSecondPart,
                    regNoThiredPart = model.regNoThiredPart,
                    //madeBy = model.madeBy,
                    //madeIn = model.madeIn,
                    //modelNo = model.modelNo,
                    //mfcDate = model.mfcDate,
                    engineNo = model.engineNo,
                    //chasisNo = model.chasisNo,
                    //ccNo = model.ccNo,
                    vehicleModelNo = model.modelNo
                };

                int vchid = await lostAndFoundService.SaveVehicleInformation(vehicleInformation);

                AttachmentInformation attachment = new AttachmentInformation
                {
                    gDInformationId=gdId,
                    encodedImage=model.encodedImage,
                    fileSubject=model.vehicleDescription
                };

                int imageId = await lostAndFoundService.SaveAttachmentInformation(attachment);

                return Ok(gdId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       

        //POST: api/LostFound/UploadImage
        [HttpPost("{file}")]
        [AllowAnonymous]
        public IActionResult UploadImage([FromBody] IFormFile file)
        {


            string attachPath = string.Empty;
            if (file != null)
            {
                string fileName;
                string message = FileSave.SaveImage(out fileName, "Upload/Attachment/vehicle", file);

                if (message == "success")
                {
                    attachPath = fileName;
                }
            }



            return Ok(attachPath);
           

        }

        //POST: api/LostFound/UploadImage
        [HttpPost]
        [AllowAnonymous]
        public IActionResult UploadImageWithEncode(FileUpload fileUpload)
        {
            //var obj = new ImageConvertor();
            //Image imageIn = obj.ConvertByteArrayToImage(fileUpload.file);
            //string fileName = Path.Combine("Upload/Attachment/vehicle", DateTime.Now.Ticks + "jpg");
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileName);
            //Stream streams = new MemoryStream(fileUpload.file);
            //MemoryStream ms = new MemoryStream(fileUpload.file);
            //System.Net.Mime.MediaTypeNames.Image.Image img = System.Net.Mime.MediaTypeNames.Image.FromStream(ms);
            //img.Save(path, ImageFormat.Jpeg);

            //File.WriteAllBytes("Foo.txt", fileUpload.file); // Requires System.IO

            //using (var stream = new FileStream(path, FileMode.Create))
            //{
            //    img.CopyTo(stream);
            //}

            return Ok("success");


        }

        //public static Image Base64ToImage(string base64String)
        //{

        //    byte[] imageBytes = Convert.FromBase64String(base64String);
        //    Image image;
        //    using (MemoryStream inStream = new MemoryStream())
        //    {
        //        inStream.Write(imageBytes, 0, imageBytes.Length);

        //        image = Bitmap.FromStream(inStream);
        //        // image.Save(inStream, System.Drawing.Imaging.ImageFormat.Png);
        //        image.Save(inStream, image.RawFormat);
        //    }

        //    return image;
        //}

        // GET: api/LostFound/GetVehicleDetailsInformationByGDId/3
        [HttpGet("{id}")]
        public async Task<GDVehicleDetailsInformationModel> GetVehicleDetailsInformationByGDId(int id)
        {
            GDVehicleDetailsInformationModel model = new GDVehicleDetailsInformationModel
            {
                gDInformation=await lostAndFoundService.GetGDInformationById(id),
                vehicleInformation= await lostAndFoundService.GetVehicleInformationByGDId(id),
                otherPersonInformation=await lostAndFoundService.GetOtherPersonInformationByGDId(id),
                indentifyInfo=await lostAndFoundService.GetIndentifyInfoByGDId(id),
                spaceAndTime=await lostAndFoundService.GetSpaceAndTimeByGDId(id),
            };
           
            return model;
        }

        // GET: api/LostFound/GetManDetailsInformationByGDId/3
        [HttpGet("{id}")]
        public async Task<GDVehicleDetailsInformationModel> GetManDetailsInformationByGDId(int id)
        {
            GDVehicleDetailsInformationModel model = new GDVehicleDetailsInformationModel
            {
                gDInformation = await lostAndFoundService.GetGDInformationById(id),
                vehicleInformation = await lostAndFoundService.GetVehicleInformationByGDId(id),
                otherPersonInformation = await lostAndFoundService.GetOtherPersonInformationByGDId(id),
                indentifyInfo = await lostAndFoundService.GetIndentifyInfoByGDId(id),
                spaceAndTime = await lostAndFoundService.GetSpaceAndTimeByGDId(id),
            };

            return model;
        }

        // GET: api/LostFound/GetAllVehicleModelNo
        [HttpGet]
        public async Task<IEnumerable<string>> GetAllVehicleModelNo()
        {
            var result =await lostAndFoundService.GetAllVehicleModelNo();

            return result;
        }

        // GET: api/LostFound/GetVehicleInformationBySearching
        [HttpGet("{vehicleTypeId}/{brandId}/{modelNo}/{regiNo}/{engineNo}/{chesisNo}/{cc}/{colorId}/{userName}")]
        public async Task<IEnumerable<VehicleInformation>> GetVehicleInformationBySearching(int? vehicleTypeId, int? brandId, string modelNo, string regiNo, string engineNo, string chesisNo, string cc, int? colorId,string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var result = await lostAndFoundService.GetVehicleInformationBySearching(vehicleTypeId, brandId, modelNo, regiNo, engineNo, chesisNo, cc, colorId,user.Id);

            return result;
        }

        // GET: api/LostFound/GetMenGDInformationBySearching
        [HttpPost]
        [AllowAnonymous]
        public async Task<IEnumerable<GDInformation>> GetMenGDInformationBySearching([FromBody]GDManInformationViewModel model)
        {
            var result = await lostAndFoundService.GetMenInformationBySearching(model);

            return result;
        }

        //POST: api/LostFound/SaveOtherDocumentDetails
        [HttpPost]
        public async Task<IActionResult> SaveOtherDocumentDetails(OtherDocumentInformationViewModel model)
        {
            try
            {
                string attachPath = string.Empty;
                if (model.formFile != null)
                {
                    string fileName;
                    string message = FileSave.SaveImage(out fileName, "Upload/Attachment/OtherDocumentDetail", model.formFile);

                    if (message == "success")
                    {
                        attachPath = fileName;
                    }
                }
                OtherDocumentDetail otherDocumentDetail = new OtherDocumentDetail
                {
                    Id = (int)model.otherId,
                    gDInformationId = model.gDInformationId,
                    documentTypeId = model.documentTypeId == 0 ? null : model.documentTypeId,
                    typeName = model.typeName,
                    description = model.description,
                    modelName=model.modelName,
                    price=model.price,
                    quantity=model.quantity,
                    attachment=attachPath
                };

                int gdId = await otherDocumentService.SaveOtherDocumentDetail(otherDocumentDetail);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/LostFound/GetManInformationByGDId/3
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ManInformation> GetManInformationByGDId(int id)
        {
            var result = await lostAndFoundService.GetManInformationByGDId(id);
            return result;
        }

        [HttpGet("{userName}/{vehicleTypeId}")]
        [AllowAnonymous]
        public async Task<IEnumerable<NewsFeedViewModel>> GetALLNewFeedsInfo(string userName,int vehicleTypeId)
        {
            var result = await lostAndFoundService.GetALLNewFeedsInfo(userName,vehicleTypeId);
            return result;
        }

        // GET: api/LostFound/GetGDInformationByUser/
        [HttpGet("{userName}")]
        public async Task<IEnumerable<GDInformation>> GetGDInformationByUser(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var result = await lostAndFoundService.GetAllGDInformationByUser(user.Id);

            List<GDInformation> lstGD = new List<GDInformation>();
            
            GDInformation gD7 = new GDInformation();
            gD7.documentDescription = "Upload/Attachment/vehicle/vic8.jpg";
            gD7.gdFor = "Aria";
            gD7.status = "Lost from Japan Garden city garrage  Yard. There are a  scratch on the right door . Well organized";
            gD7.date = "6 hours";
            gD7.gdNumber = "Upload/Attachment/profilepic/pf8w.png";
            lstGD.Add(gD7);

            GDInformation gD1 = new GDInformation();
            gD1.documentDescription = "Upload/Attachment/vehicle/vic2.jpg";
            gD1.gdFor = "Mohammad Abdullah";
            gD1.status = "Lost from Bashabo Sobujbagh Market Front Yard. There are no scratch on the body .  With second hand purchase , I use the car above for 3 years.";
            gD1.date = "10 hours";
            gD1.gdNumber = "Upload/Attachment/profilepic/pf2.png";
            lstGD.Add(gD1);

            GDInformation gD8 = new GDInformation();
           gD8.documentDescription = "Upload/Attachment/vehicle/vic9.jpg";
           gD8.gdFor = "Layla";
           gD8.status = "Lost from Khilgaw taltola.Single & four wheelar. There are  scratch on left back door and front right door  on the car . Well organized";
           gD8.date = "1 hours";
           gD8.gdNumber = "Upload/Attachment/profilepic/pf9w.png";
           lstGD.Add(gD8);

            GDInformation gD11 = new GDInformation();
            gD11.documentDescription = "Upload/Attachment/vehicle/vim12.jpg";
            gD11.gdFor = "Steven";
            gD11.status = "My pulser 150 red was lost today from Mohakhali, It was approximate 3.30pm lost from wari. My bike reg. Number Dhaka metro ha-542321";
            gD11.date = "12 days";
            gD11.gdNumber = "Upload/Attachment/profilepic/pf12.png";
            lstGD.Add(gD11);

            GDInformation gD5 = new GDInformation();
            gD5.documentDescription = "Upload/Attachment/vehicle/vic6.jpg";
            gD5.gdFor = "Emily";
            gD5.status = "Lost from Japan Garden city garrage  Yard. There are a  scratch on the right door . Well organized";
            gD5.date = "10 hours";
            gD5.gdNumber = "Upload/Attachment/profilepic/pf6w.png";
            lstGD.Add(gD5);

            GDInformation gD12 = new GDInformation();
            gD12.documentDescription = "Upload/Attachment/vehicle/vim13.jpg";
            gD12.gdFor = "Adabor Thana"; 
            gD12.status = "আমার হিরো স্প্লেন্ডার বাইক আজ হারানো গিয়েছে আদাবর থেকে। বাইকটিকালোরংনিলস্টিকারবাইকেরসামনেএক্তিহলুদস্টিকারআছেলেখাসাংবাদিক, গাড়ীরনম্বরখুলনামেট্রো হ- ৩৩১৬১২";
            gD12.date = "3 hours";
            gD12.gdNumber = "Upload/Attachment/profilepic/pfs1.jpg";
            lstGD.Add(gD12);

            GDInformation gD4 = new GDInformation();
            gD4.documentDescription = "Upload/Attachment/vehicle/vic5.jpg";
            gD4.gdFor = "Elizabeth";
            gD4.status = "Lost from Japan mascot plaza uttora. There are no scratch on the car . Well organized";
            gD4.date = "10 hours";
            gD4.gdNumber = "Upload/Attachment/profilepic/pf5w.png";
            lstGD.Add(gD4);

            GDInformation gD13 = new GDInformation();
            gD13.documentDescription = "Upload/Attachment/vehicle/vim14.jpg";
            gD13.gdFor = "Ronald";
            gD13.status = "My Fzs version 3 newly edition just been theft today. I went puran Dhaka to buy biryani from star kebab when I come back I saw my bike wasn’t there. Though I locked it properly. If any one see this bike registration numberDinajpur metro ha- 221201";
            gD13.date = "9 hours";
            gD13.gdNumber = "Upload/Attachment/profilepic/pfs2.png";
            lstGD.Add(gD13);

            GDInformation gD3 = new GDInformation();
            gD3.documentDescription = "Upload/Attachment/vehicle/vic4.jpg";
            gD3.gdFor = "Sofia";
            gD3.status = "Lost from Tejgaw love road.Single & four wheelar. There are no scratch on the car . Well organized";
            gD3.date = "10 hours";
            gD3.gdNumber = "Upload/Attachment/profilepic/pf4w.png";
            lstGD.Add(gD3);

            GDInformation gD10 = new GDInformation();
            gD10.documentDescription = "Upload/Attachment/vehicle/vic11.jpg";
            gD10.gdFor = "Jeffrey";
            gD10.status = "Lost from Japan Gazipur adomali market front site. There are no scratch on the car . Well organized";
            gD10.date = "15 days";
            gD10.gdNumber = "Upload/Attachment/profilepic/pf11.png";
            lstGD.Add(gD10);

            GDInformation gD = new GDInformation();
            gD.documentDescription = "Upload/Attachment/vehicle/vic1.jpg";
            gD.gdFor = "Suzauddaula Suza";
            gD.status = "Lost from Bashabo Sobujbagh Market Front Yard. There are no scratch on the body .  With second hand purchase , I use the car above for 3 years.";
            gD.date = "10 hours";
            gD.gdNumber = "Upload/Attachment/profilepic/pf1.png";
            lstGD.Add(gD);

            GDInformation gD14 = new GDInformation();
            gD14.documentDescription = "Upload/Attachment/vehicle/vim15.jpg";
            gD14.gdFor = "Banani Thana";
            gD14.status = "বানানীথানায়একটিপালসারবাইকউদ্ধারহয়েছে। বাইকেরনম্বরঢাকামেট্রো হ- ৪২১২১২, চেসিসনাম্বার ১০৩৯৫৩৮৩৪২৩৮৮, বাইকটিরহেডলাইটএকটুভাঙাআছে। বাইকেরআসলমালিকউপযূক্তপ্রমানদিয়েনিয়েযাবেন।";
            gD14.date = "2 days";
            gD14.gdNumber = "Upload/Attachment/profilepic/pfs3.png";
            lstGD.Add(gD14);

            GDInformation gD6 = new GDInformation();
            gD6.documentDescription = "Upload/Attachment/vehicle/vic7.jpg";
            gD6.gdFor = "Camila";
            gD6.status = "Lost from Bashundhora city Market Front Yard. There are a  scratch on the left door and windshield . There will be propelar on the back side and well organized";
            gD6.date = "5 days";
            gD6.gdNumber = "Upload/Attachment/profilepic/pf7w.png";
            lstGD.Add(gD6);

            GDInformation gD2 = new GDInformation();
            gD2.documentDescription = "Upload/Attachment/vehicle/vic3.jpg";
            gD2.gdFor = "Sadaf Rassel";
            gD2.status = "Lost from Khilgaw taltola.Single & four wheelar. There are  scratch on left back door and front right door  on the car . Well organized";
            gD2.date = "10 hours";
            gD2.gdNumber = "Upload/Attachment/profilepic/pf3.png";
            lstGD.Add(gD2);

            GDInformation gD15 = new GDInformation();
            gD15.documentDescription = "Upload/Attachment/vehicle/vim16.jpg";
            gD15.gdFor = "Badda Thana";
            gD15.status = "তুরাগথানায়একটিইয়ামাহাগ্লাডিয়েটর ১২৫ সিসিবাইকজব্দহয়েছে। বাইকেরনম্বরঢাকামেট্রো হ- ৫০৬৭৩৬, চেসিসনাম্বার৫৭৪৪২৩২৩৮৮, বাইকেরআসলমালিকউপযূক্তপ্রমানদিয়েনিয়েযাবারঅনুরোধজানানোহচ্ছে।";
            gD15.date = "2 days";
            gD15.gdNumber = "Upload/Attachment/profilepic/pfs4.png";
            lstGD.Add(gD15);

            GDInformation gD16 = new GDInformation();
            gD16.documentDescription = "Upload/Attachment/vehicle/vim17.jpg";
            gD16.gdFor = "Nicholas";
            gD16.status ="I just lost my bike today near from Bashundhara.I am feeling really pained. It was a green hero hunk 150 green color one big scratch in fron side tank.Registration number: Dhaka metro Ha - 202529";
            gD16.date = "12 days";
            gD16.gdNumber = "Upload/Attachment/profilepic/pf13.png";
            lstGD.Add(gD16);

            GDInformation gD9 = new GDInformation();
            gD9.documentDescription = "Upload/Attachment/vehicle/vic10.jpg";
            gD9.gdFor = "Abu Rayhan";
            gD9.status = "Lost from Tejgaw love road.Single & four wheelar. There are no scratch on the car . Well organized";
            gD9.date = "1 hours";
            gD9.gdNumber = "Upload/Attachment/profilepic/pf10.png";
            lstGD.Add(gD9);

            return lstGD;
        }

        

        // GET: api/LostFound/GetCountGDInformationStatus/
        [HttpGet("{userName}")]
        public async Task<StatusTypeViewModel> GetCountGDInformationStatus(string userName)
        {
            var user =await _userManager.FindByNameAsync(userName);
            var result =lostAndFoundService.GetCountGDInformationStatus(user.Id);
            return result;
        }

        // GET: api/LostFound/GetCountGDInformationByGDType/
        [HttpGet("{userName}/{statusId}")]
        public async Task<GDTypeStatusModel> GetCountGDInformationByGDType(string userName,int statusId)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var result = lostAndFoundService.GetCountGDInformationByGDType(user.Id,statusId);
            return result;
        }

        // GET: api/LostFound/GetAllGDInformationByFiltering/
        [HttpGet("{userName}/{statusId}/{gdTypeId}")]
        public async Task<IEnumerable<GDInformation>> GetAllGDInformationByFiltering(string userName, int statusId,int gdTypeId)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var result =await lostAndFoundService.GetAllGDInformationByFiltering(statusId,gdTypeId, user.Id);
            return result;
        }

        // put: api/LostFound/UpdateGDInformationStatusById/26/1023
        [HttpPut("{id}/{statusId}")]
        public string UpdateGDInformationStatusById(int id, int statusId)
        {
            string result = "error";

            try
            {
                lostAndFoundService.UpdateGDInformationStatusById(id,statusId);

                result = "success";

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Likes

        // GET: api/LostFound/GetAllLikes
        [HttpGet]
        public async Task<IEnumerable<Likes>> GetAllLikes()
        {
            var result = await lostAndFoundService.GetAllLikes();

            return result;
        }

        // POST: api/LostFound/SaveLikes
        [HttpPost]
        [AllowAnonymous]
        public async Task<string> SaveLikes([FromBody]LikesViewModel model)
        {
            string msg = "error";

            Likes likes = new Likes
            {
                ApplicationUserId = model.ApplicationUserId,
                vehicleId = model.vehicleId,
                attachmentId = model.attachmentId,
                statusId = 1
            };

            int result = await lostAndFoundService.SaveLikes(likes);

            if(result == 1)
            {
                msg = "success";
            }

            return msg;
        }

        #endregion

        // GET: api/LostFound/GetManInfo/
        //[HttpGet]
        //public GDManInformationViewModel GetManInfo()
        //{
        //    List<DNAProfileViewModel> lstDNAProfile = new List<DNAProfileViewModel>();
        //    DNAProfileViewModel viewModel1 = new DNAProfileViewModel
        //    {
        //        locous="ADF",
        //        genotype1="AD",
        //        genotype2="A"
        //    };
        //    DNAProfileViewModel viewModel2 = new DNAProfileViewModel
        //    {
        //        locous = "ADF",
        //        genotype1 = "AD",
        //        genotype2 = "A"
        //    };
        //    lstDNAProfile.Add(viewModel1);
        //    lstDNAProfile.Add(viewModel2);
        //    List<AttachmentFile> lstFiles = new List<AttachmentFile>();
        //    IFormFile formFile=null;
        //    AttachmentFile file = new AttachmentFile
        //    {
        //        formFile= formFile
        //    };
        //    lstFiles.Add(file);
        //    GDManInformationViewModel model = new GDManInformationViewModel
        //    {
        //        addressDetails = "ad",
        //        addressType = "ad",
        //        gDTypeId = 1,
        //        //dNAProfileViewModels=lstDNAProfile,
        //        //attachmentFiles= lstFiles

        //    };
        //    return model;
        //}

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}