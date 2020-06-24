using LostAndFound.Areas.Auth.Models.Lang;

namespace LostAndFound.Areas.Auth.Models
{
    public class OTPCodeVarificationViewModel
    {
        public string otpCode { get; set; }
        public int? isVarified { get; set; }
        public OTPVarifiedLn oLang { get; set; }
    }
}
