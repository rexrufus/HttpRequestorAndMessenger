
using System;
using System.Net.Mail;

namespace HttpRequestorAndMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            String sSearch = "Registration for guaranteed admittance is now full. Any spots returned will be immediately available for registration, so keep an eye on the Eventbrite event for when spots may be returned and check back here frequently.";

            String sOut = HttpRequestorAndMessenger.HttpWebRequestor.sMakeHTTPCall("https://www.eventbrite.com/e/passholder-appreciation-night-2019-registration-64187900739");
            
            // XXXYYYZZZZ@msg.fi.google.com

            if (!sOut.Contains(sSearch))
            {
                MailAddress fromAddress = new MailAddress("<fromEmail>@gmail.com", "From HttpRequestAndSMS");
                MailAddress toAddress = new MailAddress("<ToEmail>", "Check EventBright");
                const string fromPassword = "<fromPassword>";
                const string subject = "Check EventBright!!!";
                const string body = "See if tickets are avaiable!!! \r\n" +
                    "\r\n" +
                    "https://www.eventbrite.com/e/passholder-appreciation-night-2019-registration-64187900739";

                cSendGmail.bSendGmail(fromAddress, toAddress, fromPassword, subject, body);

                Console.WriteLine("What are you waiting for!!!!");
            }
            else
            {
   
                
                Console.WriteLine("Sold out :(");
            }

        }
    }
}
