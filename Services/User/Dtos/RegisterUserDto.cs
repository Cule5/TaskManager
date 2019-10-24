using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Services.User.Dtos
{
    public class RegisterUserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public EUserType UserType { get; set; }
    }
}
