using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Exceptions
{
    public class EmailException:Exception
    {
        public EmailException(string message) : base(message)
        {

        }
    }
}
