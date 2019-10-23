using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Group.Exceptions
{
    public class GroupException:Exception
    {
        public GroupException(string message):base(message)
        {

        }
    }
}
