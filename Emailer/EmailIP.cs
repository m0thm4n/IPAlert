using System;
using FluentEmail.Mailgun;
using FluentEmail.Core;
using Config;
using System.Collections.Generic;

namespace Emailer
{
    public class EmailIP
    {
        public void SendEmail(string output)
        {
            Mailgun mailgun = new Mailgun();

            mailgun = GetMailgunConfig();
            string domain = mailgun.domain;
            string apiKey = mailgun.apiKey;

            System.Console.WriteLine("This is a " + mailgun);

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

        public Mailgun GetMailgunConfig()
        {
            var config = GetConfig.LoadConfig();

            foreach (var item in config)
            {
                return new Mailgun
                {
                    domain = item.domain.ToString(),
                    apiKey = item.apiKey.ToString(),
                };
            }

            return null;
        }

        public EmailIP()
        {
            
        }
    }
}
