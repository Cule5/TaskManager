using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Command
{
    public class LoginUser:ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
