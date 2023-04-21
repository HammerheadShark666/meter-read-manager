using SendGrid;
using SendGrid.Helpers.Mail;

namespace MeterReadManager.Helper
{
    public class SendGridEmailHelper
    {
        public async static void SendEmail(string to, string subject, string html, string from = "")
        {      
            var msg = MailHelper.CreateSingleEmail(new EmailAddress(EnvironmentVariablesHelper.SendGridDefaultFromEmail()), 
                                                   new EmailAddress(to), 
                                                   subject, "", html);

            var client = new SendGridClient(EnvironmentVariablesHelper.SendGridApiKey());
            var response = await client.SendEmailAsync(msg);
        } 
    }
}
