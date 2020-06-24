using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Services.MasterData.Interfaces;
using LostAndFound.Services.SMSService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressCategoryController : ControllerBase
    {
        private readonly IAddressCategoryService addressCategoryService;
        private readonly ISMSConfigureService iSMSConfigureService;

        public AddressCategoryController(IAddressCategoryService addressCategoryService, ISMSConfigureService iSMSConfigureService)
        {
            this.addressCategoryService = addressCategoryService;
            this.iSMSConfigureService = iSMSConfigureService;
        }

        public async Task<IEnumerable<AddressCategory>> GetAllAddressCategory()
        {
            IEnumerable<AddressCategory> data = await addressCategoryService.GetAllAddressCategory();

            return data;
        }

        public async Task<string> SaveAddressCategory(AddressCategory addressCategory)
        {
            string msg = "error";

            int response = await addressCategoryService.SaveAddressCategory(addressCategory);

            if (response == 1)
            {
                msg = "success";
            }

            return msg;
        }

        public async Task<string> DeleteAddressCategory(int id)
        {
            string msg = "error";

            int response = await addressCategoryService.DeleteAddressCategoryById(id);

            if (response == 1)
            {
                msg = "success";
            }

            return msg;
        }

        [HttpGet]
        public async Task<string> SendSMSOTP(string mobile, string message, string token)
        {
            var result = await iSMSConfigureService.SendSMSAsync(mobile, message, token);
            return result;
        }
    }
}