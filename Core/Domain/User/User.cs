﻿using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Core.Domain.Common;

namespace Core.Domain.User
{
    public class User
    {
        public User()
        {

        }
        public User(string name,string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public User(string name,string lastName,EUserType userType)
        {
            Name = name;
            LastName = lastName;
            UserType = userType;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public EUserType UserType { get; set; }
        public virtual Group.Group Group { get; set; }
        public int AccountId { get; set; }
        public virtual Account.Account Account { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }=new List<Task.Task>();
        public virtual ICollection<Conversation.Conversation> Conversations { get; set; }=new List<Conversation.Conversation>();
        public virtual ICollection<ProjectUser.ProjectUser> ProjectUsers { get; set; }=new List<ProjectUser.ProjectUser>();
        
        
    }
}
