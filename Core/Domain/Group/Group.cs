using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Group
{
    public class Group
    {
        public Group(string groupName)
        {
            GroupName = groupName;
        }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Group);
        }

        public virtual bool Equals(Group group)
        {
            if (group == null)
                return false;
            if (object.ReferenceEquals(this, group))
                return true;
            return GroupName.Equals(group.GroupName);
        }

        public override int GetHashCode()
        {
            return GroupId;
        }
    }
}
