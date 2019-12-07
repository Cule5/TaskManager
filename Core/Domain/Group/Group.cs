using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        [Required]
        public string GroupName { get; set; }
        public virtual ICollection<User.User> Users { get; set; }=new List<User.User>();
        
        
        
    }
}
