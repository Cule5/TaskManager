using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.GroupProject;

namespace Core.Domain.Group
{
    public class Group
    {
        public Group()
        {

        }
        public Group(string groupName)
        {
            GroupName = groupName;
        }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
        
        
        
    }
}
