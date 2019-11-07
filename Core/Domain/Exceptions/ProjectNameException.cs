using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Exceptions
{
    public class ProjectNameException:Exception
    {
        public ProjectNameException(string message):base(message)
        {

        }
    }
}
