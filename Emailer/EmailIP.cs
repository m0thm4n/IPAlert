using System;
using Config;
using System.Threading;
using System.Threading.Tasks;
using FluentEmail.Mailgun;
using FluentEmail.Core;
using System.Net.Mail;
using System.Net;

namespace Emailer
{
    public class EmailIP
    {
        public async Task SendEmailAsync(string output)
        {
            Mailgun mailgun = new Mailgun();

            mailgun = GetConfig.LoadConfig();
            string domain = mailgun.domain;
            string apiKey = mailgun.apiKey;

            System.Console.WriteLine("This is a " + mailgun);

            var sender = new MailgunSender(
                domain,
                apiKey
            );
            Email.DefaultSender = sender;

            var email = Email
                .From("nateim3@gmail.com")
                .To("nathan.moritz@protonmail.com", "Nathan")
                .Subject("Processing Done.")
                .Body(output);

            await email.SendAsync();
        }

            //public async Task SendEmailAsync()
            //{
            //    var config = GetConfig.LoadConfig();

            //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            //    {
            //        Credentials = new NetworkCredential(config.email, config.password),
            //        EnableSsl = true
            //    };

            //    MailAddress from = new MailAddress(config.email);

            //    MailAddress to = new MailAddress("nathan.moritz@protonmail.com", "Nathan");

            //    MailMessage message = new MailMessage(from, to);
            //    message.Subject = "This is a test.";
            //    message.Body = "Test.";

            //    string userState = "test message1";

            //    client.SendAsync(message, userState);

            //}

            //public EmailIP()
            //{

            //}

            //public void SendEmail()
            //{
            //    Email config = GetConfig.LoadConfig();

            //    public static void Send(
            //        string from = null,
            //        string to = null,
            //        string subject = null,
            //        string user = null,
            //        string password = null,
            //        MimeEntity body = null,
            //        int count = 1,
            //        bool useSsl = false)
            //    {
            //        var message = new MimeMessage();

            //        message.From.Add(MailboxAddress.Parse(from ?? "ubuntupi"));
            //        message.To.Add(MailboxAddress.Parse(to ?? "nathan.moritz@protonmail.com"));
            //        message.Subject = subject ?? "Hello";
            //        message.Body = body ?? new TextPart("plain")
            //        {
            //            Text = "Hello World"
            //        };

            //        var client = new SmtpClient();

            //        client.Connect("localhost", 587, useSsl);

            //        if (user != null && password != null)
            //        {
            //            client.Authenticate(user, password)
            //        }

            //        while (count-- > 0)
            //        {
            //            client.Send(message);
            //        }

            //        client.Disconnect();
            //    }
            //}

            //private async Task StartServerAsync()
            //{
            //    var options = new SmtpServerOptionsBuilder()
            //     .ServerName("localhost")
            //     .Port(25, 587)
            //     .Build();

            //    var smtpServer = new SmtpServer.SmtpServer(options, ServiceProvider.Default);
            //    await smtpServer.StartAsync(CancellationToken.None);
            //}
        }
}
