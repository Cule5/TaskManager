using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Infrastructure.Email
{
    public class EmailSender:IEmailSender
    {
       
        public void Send(string email,string message)
        {
            MailMessage mail = new MailMessage("dominikmura6@gmail.com",email);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("dominikmura6@gmail.com", "Barcelonista5"),
                EnableSsl = true,
                Timeout = 10000
            };
            mail.Subject = "Password";
            mail.Body = "Password: " + message;
            smtp.Send(mail);
        }
    }
}
