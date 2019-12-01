using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Group.Dtos;
using Services.Project.Dtos;

namespace Services.User.Dtos
{
    public class ExtendedUserDto
    {
        public ExtendedUserDto(int userId,EUserType userType,CommonGroupDto group,IEnumerable<CommonProjectDto>projects)
        {
            UserId = userId;
            UserType = userType;
            Group = group;
            Projects = projects;
        }
        public int UserId { get; }
        public EUserType UserType { get; }
        public CommonGroupDto Group { get; }
        public IEnumerable<CommonProjectDto> Projects { get; }
    }
}
