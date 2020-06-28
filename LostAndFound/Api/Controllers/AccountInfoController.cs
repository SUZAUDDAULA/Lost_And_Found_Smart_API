using LostAndFound.Api.Models;
using LostAndFound.Areas.Auth.Models;
using LostAndFound.Data.Entity;
using LostAndFound.Helpers;
using LostAndFound.Services.jwt.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AccountInfoController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IJwtFactoryService _jwtFactory;

        public AccountInfoController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IJwtFactoryService jwtFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtFactory = jwtFactory;
        }

        //POST: api/AccountInfo/LogIn
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn([FromBody]LogInViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.FindByNameAsync(model.Name);

            if (user != null && (await _userManager.CheckPasswordAsync(user, model.Password)))
            {
                var roles = await _userManager.GetRolesAsync(user);
                var response = new
                {
                    auth_token = await _jwtFactory.GenerateToken(user.UserName, user.Id, roles)
                };

                var jwt = JsonConvert.SerializeObject(response);

                var obj = new ReturnObject
                {
                    jwt = jwt,
                    userInfo = user
                };

                return new OkObjectResult(obj);
            }

            return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));
        }

        //POST: api/AccountInfo/Register
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                string returnResult = "success";
                var ujwt = new object();
                int otpCode = 0;
                ApplicationUser user = new ApplicationUser();
                if (model.userFrom == "google")
                {
                    var gUser = await _userManager.FindByNameAsync(model.Email);
                    if (gUser != null && (await _userManager.CheckPasswordAsync(gUser, model.Password)))
                    {
                        var roles = await _userManager.GetRolesAsync(gUser);
                        var response = new
                        {
                            auth_token = await _jwtFactory.GenerateToken(gUser.UserName, gUser.Id, roles)
                        };
                        var gjwt = JsonConvert.SerializeObject(response);
                        var gobj = new ReturnObject
                        {
                            jwt = gjwt,
                            userInfo = gUser
                        };
                        return new OkObjectResult(gobj);
                    }
                    else
                    {
                        user.UserName = model.UserName;
                        user.PhoneNumber = model.PhoneNumber;
                        user.Email = model.Email;
                        user.userTypeId = 3;
                        user.FullName = model.FullName;
                        user.ImagePath = model.imagePath;
                        user.userFrom = model.userFrom;
                        user.AddressType = model.AddressType;
                        user.Citizenship = model.Citizenship;
                        user.NationalIdentityType = model.NationalIdentityType;
                        user.isVarified = 1;
                        user.otpCode = otpCode.ToString();
                        user.createdAt = DateTime.Now;
                    }
                }
                else if (model.userFrom == "mobile")
                {
                    
                    string imagePath = string.Empty;
                    if (model.formFile != null)
                    {
                        string fileName;
                        string message = FileSave.SaveImage(out fileName, "Upload/GenarelUser", model.formFile);
                        if (message == "success")
                        {
                            imagePath = fileName;
                        }
                    }

                    int _min = 1000;
                    int _max = 9999;
                    Random _rdm = new Random();
                    otpCode = _rdm.Next(_min, _max);
                    user.UserName = model.UserName;
                    user.PhoneNumber = model.PhoneNumber;
                    user.Email = model.Email;
                    user.userTypeId = 3;
                    user.Citizenship = model.Citizenship;
                    user.FullName = model.FullName;
                    user.NationalIdentityType = model.NationalIdentityType;
                    user.NationalIdentityNo = model.NationalIdentityNo;
                    user.AddressType = model.AddressType;
                    user.ImagePath = imagePath;
                    user.otpCode = otpCode.ToString();
                    user.isVarified = 0;
                    user.createdAt = DateTime.Now;
                    user.userFrom = model.userFrom;
                }
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "General User");
                    var roles = await _userManager.GetRolesAsync(user);
                    var response = new
                    {
                        auth_token = await _jwtFactory.GenerateToken(user.UserName, user.Id, roles)
                    };
                    ujwt = JsonConvert.SerializeObject(response);
                }
                else
                {
                    returnResult = "error";
                    otpCode = 0;
                }

                var obj = new ReturnObject
                {
                    jwt = ujwt,
                    otpCode = otpCode.ToString(),
                    message = returnResult,
                    userInfo=user
                };
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //POST: api/AccountInfo/UploadUserImage
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> UploadUserImage(IFormFile formFile)
        {
            
            try
            {
                var userName = User.Claims.FirstOrDefault().Value;
                string returnResult = "success";
                string imagePath = string.Empty;
                var jwt = new object();
                if (formFile != null)
                {
                    string fileName;
                    string message = FileSave.SaveImage(out fileName, "Upload/GenarelUser", formFile);

                    if (message == "success")
                    {
                        imagePath = fileName;
                    }
                }

                ApplicationUser user = await _userManager.FindByNameAsync(userName);
                user.ImagePath = imagePath;

                await _userManager.UpdateAsync(user);



                return new OkObjectResult(returnResult);

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //POST: api/AccountInfo/OTPVarified
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> OTPVarified(OtpVerification otp)
        {

            try
            {
                //var userName = User.Claims.FirstOrDefault().Value;
                string returnResult = "success";
               
                var user = await _userManager.FindByNameAsync(otp.userName);
                if (user.otpCode == otp.otpCode)
                {
                    user.isVarified = 1;
                    await _userManager.UpdateAsync(user);
                    returnResult = "success";
                }
                else
                    returnResult = "error";

                return new OkObjectResult(returnResult);

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //POST: api/AccountInfo/ProfileUpdate
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ProfileUpdate(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var ujwt = new object();
                int otpCode = 0;
                ApplicationUser user = await _userManager.FindByNameAsync(model.UserName);
                if (model.userFrom == "google")
                {
                    user.PhoneNumber = model.PhoneNumber;
                    user.Email = model.Email;
                    user.userTypeId = 3;
                    user.FullName = model.FullName;
                    user.ImagePath = model.imagePath;
                    user.userFrom = model.userFrom;
                    user.AddressType = model.AddressType;
                    user.Citizenship = model.Citizenship;
                    user.NationalIdentityType = model.NationalIdentityType;
                    user.isVarified = 1;
                    user.otpCode = otpCode.ToString();
                    user.createdAt = DateTime.Now;
                    
                }
                else if (model.userFrom == "mobile")
                {
                    //string imagePath = string.Empty;
                    //if (model.formFile != null)
                    //{
                    //    string fileName;
                    //    string message = FileSave.SaveImage(out fileName, "Upload/GenarelUser", model.formFile);
                    //    if (message == "success")
                    //    {
                    //        imagePath = fileName;
                    //    }
                    //}
                    user.PhoneNumber = model.PhoneNumber;
                    user.Email = model.Email;
                    user.userTypeId = 3;
                    user.Citizenship = model.Citizenship;
                    user.FullName = model.FullName;
                    user.NationalIdentityType = model.NationalIdentityType;
                    user.NationalIdentityNo = model.NationalIdentityNo;
                    user.AddressType = model.AddressType;
                    user.ImagePath = model.imagePath;
                    user.isVarified = 1;
                    user.updatedAt = DateTime.Now;
                    user.userFrom = model.userFrom;
                }
                
                if (model.userFrom == "google")
                {
                    await _userManager.UpdateAsync(user);
                    await _userManager.ChangePasswordAsync(user, model.Password, model.ConfirmPassword);
                }
                else
                {
                    await _userManager.UpdateAsync(user);
                }
                var userInfo = await _userManager.FindByNameAsync(model.UserName);
                return Ok(userInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //POST: api/AccountInfo/ForgetPassword
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(PasswordResetVeiwModel model)
        {

            var result = "error";

            if (!string.IsNullOrEmpty(model.UserName) && !string.IsNullOrEmpty(model.Password) && !string.IsNullOrEmpty(model.ConfirmPassword))
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                await _userManager.RemovePasswordAsync(user);

                if (user.PasswordHash == null)
                {
                    await _userManager.AddPasswordAsync(user, model.Password);
                }

                result = "success";
            }
            else
            {
                return Ok(result);
            }

            return Ok(result);
        }

        //POST: api/AccountInfo/ForgetPassword
        [HttpGet("{userName}")]
        public async Task<IActionResult> GetUserInfo(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return Ok(user);
        }

        //POST: api/AccountInfo/ResetPassword
        [HttpPost]
        public async Task<IActionResult> ResetPassword(PasswordResetVeiwModel model)
        {
            //var userName = User.Claims.FirstOrDefault().Value;
            var result = "error";

            if (!string.IsNullOrEmpty(model.UserName) && !string.IsNullOrEmpty(model.OldPassword) && !string.IsNullOrEmpty(model.Password))
            {

                var user = await _userManager.FindByNameAsync(model.UserName);

                await _userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);

                result = "success";
            }
            else
            {
                return Ok(result);
            }

            return Ok(result);
        }

        public class ReturnObject
        {
            public object jwt { get; set; }
            public string otpCode { get; set; }
            public string message { get; set; }
            public object userInfo { get; set; }
        }

        public class OtpVerification
        {
            public string userName { get; set; }
            public string otpCode { get; set; }
        }

    }
}