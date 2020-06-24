using LostAndFound.Data.Entity.Auth;
using System.Threading.Tasks;

namespace LostAndFound.Services.EmailService.interfaces
{
    public interface IEmailSenderService
    {
        Task SendEmail(string mailTo,string subject, string message);
        Task SendEmailWithFrom(string mailTo, string name, string subject, string message);
        Task<bool> SaveMailLog(MailLog mailLog); 
    }
}
