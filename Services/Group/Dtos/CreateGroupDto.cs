using System;
using System.Collections.Generic;
using System.Text;
using Services.User.Dtos;

namespace Services.Group.Dtos
{
    public class CreateGroupDto
    {
        public CreateGroupDto(string groupName,IEnumerable<CommonUserDto>users)
        {
            GroupName = groupName;
            Users = users;
        }
        public string GroupName { get; }
        public IEnumerable<CommonUserDto> Users { get; }
    }
}
