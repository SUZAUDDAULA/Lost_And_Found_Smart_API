using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Api.Models.ViewModels;
using LostAndFound.Data.Entity;
using LostAndFound.Data.Entity.LostFound;
using LostAndFound.Services.LostFoundServices.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OthersItemController : ControllerBase
    {
        private readonly ILostAndFoundService lostAndFoundService;
        private readonly IOtherDocumentService otherDocumentService;
        private readonly UserManager<ApplicationUser> _userManager;
        public OthersItemController(ILostAndFoundService lostAndFoundService, UserManager<ApplicationUser> userManager, IOtherDocumentService otherDocumentService)
        {
            this.lostAndFoundService = lostAndFoundService;
            this.otherDocumentService = otherDocumentService;
            _userManager = userManager;
        }

        // POST ::  api/OthersItem/SaveComputerInfo/computerInfoViewModel
        [HttpPost]
        public async Task<IActionResult> SaveComputerInfo(ComputerInfoViewModel model)
        {
            string msg = "error";

            try
            {
                if (!string.IsNullOrEmpty(model.model) ||
                       !string.IsNullOrEmpty(model.serialNo) ||
                       !string.IsNullOrEmpty(model.serviceCode) ||
                       !string.IsNullOrEmpty(Convert.ToString(model.districtId)) ||
                       !string.IsNullOrEmpty(Convert.ToString(model.thanaId)))
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
                    

                    int masterId = await lostAndFoundService.SaveGDInformation(gDInformation);

                    if (model.gdFor == "OTHERS")
                    {
                        OtherPersonInformation otherPerson = new OtherPersonInformation
                        {
                            gDInformationId = masterId,
                            nationalIdentityTypeId = model.nationalIdentityTypeId == 0 ? null : model.nationalIdentityTypeId,
                            identityNo = model.identityNo,
                            mobileNo = model.mobileNo
                        };
                        int opi = await lostAndFoundService.SaveOtherPersonInformation(otherPerson);
                    }

                    OtherDocumentDetail otherDocumentDetail = new OtherDocumentDetail
                    {
                        gDInformationId = masterId,
                        modelName = model.model,
                        serialNo = model.serialNo,
                        productNumber = model.serviceCode,
                        colorsId = model.colorId,
                        price = model.price,
                        currency = model.currency

                    };

                    IndentifyInfo indentifyInfo = new IndentifyInfo
                    {
                        gDInformationId = masterId,
                        identifySign = model.identificationMark,
                        colorsId = model.colorId
                    };

                    SpaceAndTime spaceAndTime = new SpaceAndTime
                    {
                        gDInformationId = masterId,
                        districtId = model.districtId,
                        thanaId = model.thanaId,
                        village = model.village,
                        placeDetails = model.addressDetails,
                        lafDate = model.date,
                        lafTime = model.time
                    };

                    await otherDocumentService.SaveOtherDocumentDetail(otherDocumentDetail);
                    await lostAndFoundService.SaveIndentifyInfo(indentifyInfo);
                    await lostAndFoundService.SaveSpaceAndTime(spaceAndTime);

                    msg = gdNumber;

                }
                return Ok(msg);
            }
            catch(Exception e)
            {
                throw e;
            }

            
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}