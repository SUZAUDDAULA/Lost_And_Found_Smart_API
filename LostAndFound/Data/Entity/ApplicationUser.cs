using LostAndFound.Data.Entity.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity
{
    public class ApplicationUser:IdentityUser
    {
        public int? userTypeId { get; set; }
        public UserType userType { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Citizenship { get; set; }

        public int? NationalIdentityType { get; set; }
        [StringLength(100)]
        public string NationalIdentityNo { get; set; }
        public int? AddressType { get; set; }

        [StringLength(300)]
        public string ImagePath { get; set; }
        public string otpCode { get; set; }
        public int? isVarified { get; set; }

        public int? isActive { get; set; }

        public DateTime? createdAt { get; set; }
        [MaxLength(120)]
        public string createdBy { get; set; }

        public DateTime? updatedAt { get; set; }
        [MaxLength(120)]
        public string updatedBy { get; set; }
    }
}
