using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace LostAndFound.Areas.ReportORApplication.Models
{
    public class GDManInformationViewModel
    {
        public int? gDInformationId { get; set; }
        public string gdFor { get; set; }
        public DateTime? gdDate { get; set; }
        public string gdNumber { get; set; }
        public int? productTypeId { get; set; }
        public int? gDTypeId { get; set; }
        public int? documentTypeId { get; set; }
        public string documentDescription { get; set; }

        // Identity Information

        public int? colorsId { get; set; }
        public string identifySign { get; set; }
        public string identifyType { get; set; }
        public int? religionId { get; set; }
        public string bloodGroup { get; set; }
        public int? occupationId { get; set; }
        public int? maritalStatusId { get; set; }
        public string attachmentPath { get; set; }
        public int? descriptionCircumcisionId { get; set; }

        // Other Person Information 

        public int? nationalIdentityTypeId { get; set; }
        public string identityNo { get; set; }
        public string mobileNo { get; set; }

        // Space and time

        public int? divisionId { get; set; }
        public int? districtId { get; set; }
        public int? thanaId { get; set; }
        public int? postOfficeId { get; set; }
        public string village { get; set; }
        public string placeDetails { get; set; }
        public DateTime? lafDate { get; set; }
        public string lafTime { get; set; }

        //Man Information
        public int? relationTypeId { get; set; }
        public string name { get; set; }
        public string aproxAge { get; set; }
        public int? agePeriodId { get; set; }
        public int? genderId { get; set; }
        public int? isHealthDisabled { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string spouseName { get; set; }
        public int? manNationalIdentityTypeId { get; set; }
        public string manIdentityNo { get; set; }
        public int? numberTypeId { get; set; }
        public string number { get; set; }
        public string deathOfDate { get; set; }
        public int? deadbodyConditionId { get; set; }

        //Man Address Info
        public int? manCountryId { get; set; }
        public int? manDistrictId { get; set; }
        public int? manThanaId { get; set; }
        public string postOffice { get; set; }
        public string postCode { get; set; }
        public string addressDetails { get; set; }
        public string oneLineAddress { get; set; }
        public string addressType { get; set; } //Type: Permamnent or Present

        //Physical Information
        public int? beardTypeId { get; set; }
        public int? bodyChinTypeId { get; set; }
        public int? bodyColorId { get; set; }
        public int? bodyStructureId { get; set; }
        public int? earTypeId { get; set; }
        public int? eyeTypeId { get; set; }
        public int? faceShapeTypeId { get; set; }
        public int? foreHeadTypeId { get; set; }
        public decimal? weight { get; set; }
        public decimal? heightFeet { get; set; }
        public decimal? heightInch { get; set; }
        public int? hairTypeId { get; set; }
        public int? headTypeId { get; set; }
        public int? moustacheTypeId { get; set; }
        public int? mouthTypeId { get; set; }
        public int? neckTypeId { get; set; }
        public int? noseTypeId { get; set; }
        public int? specialBodyConditionId { get; set; }
        public int? teethTypeId { get; set; }
        public int? specialBirthMarkTypeId { get; set; }
        public int? specialBirthMarkBodyPartId { get; set; }
        public int? specialBirthMarkBodyPartPositionId { get; set; }
        public string visibleTatto { get; set; }
        public string otherIdentityfyMark { get; set; }

        //Dress Information
        public int? inTheBodyId { get; set; }
        public int? inTheBodyColorId { get; set; }
        public int? inTheHeadId { get; set; }
        public int? inTheHeadColorId { get; set; }
        public int? inTheEyeId { get; set; }
        public int? inTheEyeColorId { get; set; }
        public int? inTheLegsId { get; set; }
        public int? inTheLegsColorId { get; set; }
        public int? inTheThroatId { get; set; }
        public int? inTheThroatColorId { get; set; }
        public int? inTheWaistId { get; set; }
        public int? inTheWaistColorId { get; set; }
        public decimal? shoesSize { get; set; }
        public string shoesSizeType { get; set; }

        public string userName { get; set; }

        List<int?> habitList { get; set; }
        List<int?> speechList { get; set; }
        //public List<AddressInformation> addressInformation { get; set; }

        public List<DNAProfileViewModel> dNAProfileViewModels { get; set; }
        public List<AttachmentFile> attachmentFiles { get; set; }
    }

    public class DNAProfileViewModel
    {
        public string locous { get; set; }
        public string genotype1 { get; set; }
        public string genotype2 { get; set; }
    }
    public class AttachmentFile
    {
        public string attachmentType { get; set; }
        public IFormFile formFile { get; set; }
    }
}
