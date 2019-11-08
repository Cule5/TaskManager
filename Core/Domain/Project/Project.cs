using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project
{
    public class Project
    {
        public Project()
        {

        }
        
        public Project(string projectName,string description,DateTime startDate)
        {
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
        }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public virtual ICollection<ProjectUser.ProjectUser> ProjectUsers { get; set; }
       
    }
}
