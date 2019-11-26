using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Group.Dtos
{
    public class CommonGroupDto
    {
        public CommonGroupDto(int groupId,string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
        }
        public int GroupId { get; }
        public string GroupName { get; }
    }
}
