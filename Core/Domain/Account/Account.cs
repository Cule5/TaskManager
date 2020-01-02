using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Domain.Common;

namespace Core.Domain.Account
{
    public class Account
    {
        public Account()
        {

        }
        
        public Account(string email,string password,EUserType userType)
        {
            Email = email;
            Password = password;
            UserType = userType;

        }
        public int AccountId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public EUserType UserType { get; set; }
        [Required]
        public virtual User.User User { get; set; }

        
    }
}
