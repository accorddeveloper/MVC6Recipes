using System;
using System.Net.Mail;

namespace Chapter05.Recipe12.Web.Infrastructure
{
    /// <summary>
    /// Summary description for MailHelper
    /// </summary>
    public static class MailHelper
    {


        public static void Send(string email, string subject, string body)
        {
            try
            {
                using (var mailmsg = new MailMessage())
                {
                    mailmsg.To.Add(email);
                    mailmsg.From = new MailAddress("noreplay@yourwebsite.com");
                    mailmsg.Subject = subject;
                    mailmsg.Body = body;
                    mailmsg.IsBodyHtml = true;

                    using (var smptClient = new SmtpClient())
                    {
#if DEBUG
                        smptClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                        smptClient.PickupDirectoryLocation = @"C:\SMTPPickup";

#endif
                        smptClient.Send(mailmsg);
                    }
                }
            }
            catch (SmtpException)
            {
                // log error
            }
            catch (System.FormatException)
            {
                // log error
            }

        }

    }
}