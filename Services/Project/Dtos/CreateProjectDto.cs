using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Project.Dtos
{
    public class CreateProjectDto
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}
