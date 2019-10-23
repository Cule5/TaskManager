using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.User.Exceptions
{
    public class UserException:Exception
    {
        public UserException(string message):base(message)
        {

        }
    }
}
