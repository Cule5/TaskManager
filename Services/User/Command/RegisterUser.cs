using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Command;

namespace Services.User.Command
{
    public class RegisterUser:ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EUserType UserType { get; set; }
        public string GroupName { get; set; }
        public IEnumerable<string> Projects { get; set; }
        
    }
}
