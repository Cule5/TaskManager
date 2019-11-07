using System;
using System.Collections.Generic;
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
        public string Email { get; set; }
        public string Password { get; set; }
        
        public virtual User.User User { get; set; }

        
    }
}
