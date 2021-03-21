using System;
using FluentEmail.Mailgun;
using FluentEmail.Core;

namespace Emailer
{
    public class EmailIP
    {
        public void SendEmail(string output)
        {
            string config = GetConfig.LoadConfig();
            string domain = config.domain;
            string apiKey = config.apiKey;

            System.Console.WriteLine("This is a " + config);

            var sender = new MailgunSender(
                domain,
                apiKey
            );
            Email.DefaultSender = sender;
            
            var email = Email
                .From("nathan.moritz@protonmail.com")
                .To("nathan.moritz@protonmail.com", "Nathan")
                .Subject("Processing Done.")
                .Body(output)
                .Send();
        }

        public EmailWhenDone()
        {
            
        }
    }
}
