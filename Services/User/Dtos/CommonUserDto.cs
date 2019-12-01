using System;
using System.Collections.Generic;
using System.Text;

namespace Services.User.Dtos
{
    public class CommonUserDto
    {
        public CommonUserDto(int userId,string name,string lastName,string email)
        {
            UserId = userId;
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
