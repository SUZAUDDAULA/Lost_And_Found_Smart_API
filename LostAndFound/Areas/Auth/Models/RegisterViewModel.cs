using LostAndFound.Areas.Auth.Models.Lang;
using LostAndFound.Data.Entity.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Areas.Auth.Models
{
    [NotMapped]
    public class RegisterViewModel
    {
        public string FullName { get; set; }
        public string Citizenship { get; set; }
        public int? NationalIdentityType { get; set; }
        public string NationalIdentityNo { get; set; }
        public int? AddressType { get; set; }
        public IFormFile formFile { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNo { get; set; }      
        public string Email { get; set; }
        public int? UserTypeId { get; set; }       
        public string userRole { get; set; }
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string userFrom { get; set; }
        public string imagePath { get; set; }

        public string[] assignRoles { get;set;}
        public string[] removeRoles { get;set;}

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public IEnumerable<UserType> userTypes { get; set; }
        public IEnumerable<IdentityRole> identityRoles { get; set; }
        public IEnumerable<AspNetUsersViewModel> aspNetUsersViewModels { get; set; }
        public RegisterLn rLang { get; set; }
    }
}
