using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Api.Models;
using LostAndFound.Services.MasterData.Interfaces.MDOtherItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MDOtherBrandController : ControllerBase
    {
        private readonly IElectronicService electronicService;

        public MDOtherBrandController(IElectronicService electronicService)
        {
            this.electronicService = electronicService;
        }

        // GET: api/MDOtherBrand/GetOtherBrandInformationMasterData
        [HttpGet]
        public async Task<MDOtherItemInformation> GetOtherBrandInformationMasterData()
        {
            MDOtherItemInformation model = new MDOtherItemInformation
            {
                electronicsTypes = await electronicService.GetAllElectronicsType(),
                fileDocumentTypes = await electronicService.GetAllFileDocumentType(),
                mobilePhoneTypes = await electronicService.GetAllMobilePhoneType(),
                mobileBrands = await electronicService.GetAllOtherBrand("mobile"),
                watchBrands = await electronicService.GetAllOtherBrand("watch"),
                shoesBrands = await electronicService.GetAllOtherBrand("shoes"),
                bagBrands = await electronicService.GetAllOtherBrand("bag"),
                electronicsBrands = await electronicService.GetAllOtherBrand("electronics"),
                jwellaryBrands = await electronicService.GetAllOtherBrand("jwellary"),
                glassBrands = await electronicService.GetAllOtherBrand("glass"),
                umbrellaBrands = await electronicService.GetAllOtherBrand("umbrella"),
                operatingSystemTypes=await electronicService.GetAllOperatingSystemType()
               
            };
            return model;
        }

    }
}