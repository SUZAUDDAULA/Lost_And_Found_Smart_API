using LostAndFound.Services.SMSService.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LostAndFound.Services.SMSService
{
    public class SMSConfigureService: ISMSConfigureService
    {
        public async Task<string> SendSMSAsync(string mobile, string message, string token)
        {
            // return "Skip";
            if (token == "Opus@1234")
            {
                try
                {
                    string url = String.Format("http://api.boom-cast.com/boomcast/WebFramework/boomCastWebService/externalApiSendTextMessage.php?masking=NOMASK&userName=OpusTech&password=c3eb7e87b84e252777057a07d984e98e&MsgType=TEXT&receiver={0}&message={1}", mobile, message);

                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    dynamic data = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());

                    if (data[0].success == 1) return "success";
                    return "fail";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            else
            {
                return "Invalid Token";
            }
        }
    }
}
