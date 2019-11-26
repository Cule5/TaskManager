using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Project.Dtos;

namespace Services.User.Dtos
{
    public class RegisterUserDto
    {
        public RegisterUserDto(string name,string lastName,string email,int groupId,IEnumerable<CommonProjectDto>projects,EUserType userType)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            GroupId = groupId;
            Projects = projects;
            UserType = userType;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<CommonProjectDto> Projects { get; set; }
        public EUserType UserType { get; set; }
    }
}
