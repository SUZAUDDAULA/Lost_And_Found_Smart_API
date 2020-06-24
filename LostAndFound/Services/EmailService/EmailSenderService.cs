using LostAndFound.Data;
using LostAndFound.Data.Entity.Auth;
using LostAndFound.Services.EmailService.interfaces;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LostAndFound.Services.EmailService
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IConfiguration _configuration;
        private readonly LAFDbContext _context;

        public EmailSenderService(IConfiguration configuration, LAFDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task SendEmail(string mailTo, string subject, string message)
        {
            string userName = _configuration["EmailSettings:Email"];
            string password = _configuration["EmailSettings:Password"];
            string host = _configuration["EmailSettings:Host"];
            int port = int.Parse(_configuration["EmailSettings:Port"]);
            string mailFrom = _configuration["EmailSettings:Email"];
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName =userName,
                    Password = password
                };

                client.Credentials = credential;
                client.Host = host;
                client.Port = port;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(mailTo));
                    emailMessage.From = new MailAddress(mailFrom);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    emailMessage.IsBodyHtml = true;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }


        public async Task SendEmailWithFrom(string mailTo, string name, string subject, string message)
        {
            string userName = _configuration["EmailSettings:Email"];
            string password = _configuration["EmailSettings:Password"];
            string host = _configuration["EmailSettings:Host"];
            int port = int.Parse(_configuration["EmailSettings:Port"]);
            string mailFrom = _configuration["EmailSettings:Email"];
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = userName,
                    Password = password
                };

                client.Credentials = credential;
                client.Host = host;
                client.Port = port;
                client.EnableSsl = true;
                //client.UseDefaultCredentials = true;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(mailTo));
                    emailMessage.From = new MailAddress(mailFrom,name);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    emailMessage.IsBodyHtml = true;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }

        public async Task<bool> SaveMailLog(MailLog mailLog)
        {
            if (mailLog.Id != 0)
                _context.MailLogs.Update(mailLog);
            else
                _context.MailLogs.Add(mailLog);

            return 1 == await _context.SaveChangesAsync();
        }
    }
}
