using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exceptions
{
    public class LoginPasswordException:Exception
    {
        public LoginPasswordException(string message):base(message)
        {

        }
    }
}
