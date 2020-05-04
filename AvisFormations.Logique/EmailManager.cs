using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AvisFormations.Logique
{
    public class EmailManager
    {
        public void SendEmail(string titre, string message, string email)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress("bourkha.hamza@epim.ma"));
            msg.Subject = "Nouveau message AvisFormations";

            // You need to use Index because that is the name declared above
            msg.Body = message;
            var client = new SmtpClient
            {
                Host = "mail.epim.ma",
                Port = 465,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Timeout = 30 * 1000,
                Credentials = new NetworkCredential("bourkha.hamza@epim.ma", "inter2017consulting")
            };
            client.Send(msg);

        }
    }
}
