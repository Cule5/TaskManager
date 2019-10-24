using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Exceptions
{
    public class GroupNameException:Exception
    {
        public GroupNameException(string message):base(message)
        {

        }
    }
}
