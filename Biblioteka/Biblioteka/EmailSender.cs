using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class EmailSender
    {
        private string host = "smtp-relay.gmail.com";
        private string username = "user";
        private string password = "passwd";
        private string to;
        private string message;

        public EmailSender(string to, string message)
        {
            this.to = to;
            this.message = message;
        }

        public void send()
        {
            SmtpClient smtpClient = new SmtpClient(host);
            smtpClient.Credentials = new System.Net.NetworkCredential(this.username, this.password);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(new MailAddress(this.to));
            mailMessage.Subject = "Powiadomienie - Biblioteka";
            mailMessage.Body = this.message;
            smtpClient.Send(mailMessage);
        }
    }
}
