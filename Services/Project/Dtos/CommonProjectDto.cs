using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Project.Dtos
{
    public class CommonProjectDto
    {
        public CommonProjectDto(int projectId,string projectName)
        {
            ProjectId = projectId;
            ProjectName = projectName;
        }
        public int ProjectId { get;}
        public string ProjectName { get;}
    }
}
