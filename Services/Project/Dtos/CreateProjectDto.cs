using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Project.Dtos
{
    public class CreateProjectDto
    {
        public CreateProjectDto(string projectName,string description,DateTime startDate)
        {
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
        }
        public string ProjectName { get;  }
        public string Description { get; }
        public DateTime StartDate { get; }
    }
}
