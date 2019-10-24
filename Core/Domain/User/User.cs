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
        public User(string name,string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public User(string name,string lastName,EUserType userType,Account.Account account)
        {
            Name = name;
            LastName = lastName;
            UserType = userType;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public EUserType UserType { get; set; }
        public int GroupId { get; set; }
        public virtual Group.Group Group { get; set; }
        public int AccountId { get; set; }
        public Account.Account Account { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as User);
        }

        public virtual bool Equals(User user)
        {
            if (user == null)
                return false;
            if (object.ReferenceEquals(this, user))
                return true;
            return Name == user.Name && LastName == user.LastName;
        }

        public override int GetHashCode()
        {
            return UserId;
        }
    }
}
