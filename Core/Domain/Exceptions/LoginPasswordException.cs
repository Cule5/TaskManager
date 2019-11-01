using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Exceptions
{
    public class LoginPasswordException:Exception
    {
        public LoginPasswordException(string message):base(message)
        {

        }
    }
}
