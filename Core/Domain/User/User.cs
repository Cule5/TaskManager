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
        private string _emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public EUserType UserType { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }

        private bool CheckEmail(string email)
        {
            var tmpEmail = email.ToLower();
            Regex regex=new Regex(_emailPattern);
            return regex.IsMatch(tmpEmail);
        }
    }
}
