using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Core.Domain.Common;

namespace Core.Domain.User
{
    public class User
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public User(string login,string password,EUserType userType)
        {
            Login = login;
            Password = password;
            UserType = userType;
        }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public EUserType UserType { get; set; }
        public int GroupId { get; set; }
        public virtual Group.Group Group { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }
        public virtual ICollection<Report.Report> Reports { get; set; }
        public override bool Equals(object other)
        {
            return Equals(other as User);
        }

        public virtual bool Equals(User user)
        {
            if (user == null)
                return false;
            if (object.ReferenceEquals(this, user)) { return true; }

            return Login == user.Login && Password == user.Password;
        }

        public override int GetHashCode()
        {
            return UserId;
        }
    }
}
