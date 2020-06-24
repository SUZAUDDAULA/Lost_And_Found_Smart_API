using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Services.SMSService.Interface
{
   public interface ISMSConfigureService
    {
        Task<string> SendSMSAsync(string mobile, string message,string token);
    }
}
