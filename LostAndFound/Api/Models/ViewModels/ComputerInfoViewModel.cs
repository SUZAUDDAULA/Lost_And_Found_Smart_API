
using System;

namespace LostAndFound.Api.Models.ViewModels
{
    public class ComputerInfoViewModel
    {
        //GD Information
        public string gdFor { get; set; }
        public DateTime? gdDate { get; set; }
        public string gdNumber { get; set; }
        public int? productTypeId { get; set; }
        public int? gDTypeId { get; set; }
        public int? documentTypeId { get; set; }
        public string documentDescription { get; set; }
        public string userName { get; set; }

        // Other Person Information 
        public int? nationalIdentityTypeId { get; set; }
        public string identityNo { get; set; }
        public string mobileNo { get; set; }

        //Computer Info
        public int? brandTypeId { get; set; }
        public string model { get; set; }
        public string serialNo { get; set; }
        public string emcProductId { get; set; }
        public string serviceCode { get; set; }
        public int? colorId { get; set; }

        public decimal? price { get; set; }

        public string currency { get; set; }

        public string identificationMark { get; set; }

        public int? districtId{ get; set; }
        public int? thanaId { get; set; }
        public string village{ get; set; }
        public string addressDetails { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
    }
}
