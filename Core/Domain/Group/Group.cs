using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Group
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
    }
}
