using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;

namespace Services.User.Command
{
    public class RegisterUser:ICommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
