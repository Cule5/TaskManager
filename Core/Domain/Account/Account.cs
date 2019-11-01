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
        public Account(string login)
        {
            Login = login;
        }
        public Account(string login,string password)
        {
            Login = login;
            Password = password;
        }
        public int AccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual User.User User { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Account);
        }

        public virtual bool Equals(Account account)
        {
            if (account == null)
                return false;
            return account.Login.Equals(Login) && account.Password.Equals(Password);
        }

        public override int GetHashCode()
        {
            return (GetRealType().ToString() + AccountId).GetHashCode();
        }

        private Type GetRealType()
        {
            return GetType();
        }
    }
}
