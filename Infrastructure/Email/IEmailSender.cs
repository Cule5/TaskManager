using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Email
{
    public interface IEmailSender
    {
        void Send(string email,string message);
    }
}
