using System;
using System.Collections.Generic;
using System.Text;
using Services.Group.Dtos;
using Services.Project.Dtos;

namespace Services.User.Dtos
{
    public class ExtendedUserDto
    {
        public ExtendedUserDto(string name,string lastName,string email,CommonGroupDto group,IEnumerable<CommonProjectDto>projects)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Group = group;
            Projects = projects;
        }
        public string Name { get; }
        public string LastName { get; }
        public string Email { get; }
        public CommonGroupDto Group { get; }
        public IEnumerable<CommonProjectDto> Projects { get; }
    }
}
