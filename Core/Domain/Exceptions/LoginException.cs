using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Exceptions
{
    public class LoginException:Exception
    {
        public LoginException(string message):base(message)
        {

        }
    }
}
