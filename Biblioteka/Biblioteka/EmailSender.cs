using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

/*
Jak wysłać maila? 
EmailAccountModel model = new EmailAccountModel("smtp-mail.outlook.com", "libraryproject2019@outlook.com", "libraryproject2019", "haslodopoczty");
EmailSender mailsender = new EmailSender(model, "odbiorca@mail.com", "Nieoddana ksiazka");
mailsender.send();
*/

namespace Biblioteka
{
    class EmailSender
    {
        private string host;
        private string username;
        private string password;
        private string from;
        private string to;
        private string message;

        public EmailSender(EmailAccountModel accountModel, string to, string message)
        {
            this.host = accountModel.getHost();
            this.username = accountModel.getLogin();
            this.password = accountModel.getPasswd();
            this.from = accountModel.getAddress();
            this.to = to;
            this.message = message;
        }

        public void send()
        {
            SmtpClient smtpClient = new SmtpClient(host);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 25;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(this.from, this.password);
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(new MailAddress(this.to));
            mailMessage.From = new MailAddress(this.from);
            mailMessage.Subject = "Powiadomienie - Biblioteka";
            mailMessage.Body = this.message;
            smtpClient.Send(mailMessage);
        }

    }
}
