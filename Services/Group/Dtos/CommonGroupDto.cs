using System;
using System.Collections.Generic;
using System.Text;
using Services.User.Dtos;

namespace Services.Group.Dtos
{
    public class CommonGroupDto
    {
        public CommonGroupDto(string groupName,IEnumerable<CommonUserDto>users)
        {
            GroupName = groupName;
            Users = users;
        }
        public string GroupName { get; }
        public IEnumerable<CommonUserDto> Users { get; }
    }
}
