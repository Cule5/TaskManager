using System;
using System.Collections.Generic;
using System.Text;
using Services.User.Dtos;

namespace Services.Project.Dtos
{
    public class CreateProjectDto
    {
        public CreateProjectDto(string projectName,string description,DateTime startDate, IEnumerable<CommonUserDto>users)
        {
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
            Users = users;
        }
        public string ProjectName { get;  }
        public string Description { get; }
        public DateTime StartDate { get; }
        public IEnumerable<CommonUserDto> Users { get; }
    }
}
