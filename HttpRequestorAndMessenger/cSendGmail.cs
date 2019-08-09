
using System.Net;
using System.Net.Mail;

namespace HttpRequestorAndMessenger
{
    class cSendGmail
    {

        public static bool bSendGmail(MailAddress fromAddress
                                        ,MailAddress toAddress
                                        ,string fromPassword
                                        ,string subject
                                        ,string body
            )
        {
  
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            return true;
        }
    }
}
