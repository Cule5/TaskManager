using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domain.Account
{
    public class Account
    {
        public Account()
        {

        }
        
        public Account(string email,string password)
        {
            Email = email;
            Password = password;
        }
        public int AccountId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public virtual User.User User { get; set; }

        
    }
}
