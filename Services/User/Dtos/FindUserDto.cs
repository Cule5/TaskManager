using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Dtos
{
    public class FindUserDto
    {
        public FindUserDto(string name,string lastName,string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
