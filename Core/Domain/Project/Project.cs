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
        public Project(string projectName)
        {
            ProjectName = projectName;
        }
        public Project(string projectName,string description,DateTime startDate,DateTime endDate)
        {
            ProjectName = projectName;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<ProjectUser.ProjectUser> ProjectUsers { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Project);
        }

        public virtual bool Equals(Project project)
        {
            if (project == null)
                return false;
            return project.ProjectName.Equals(ProjectName);
        }

        public override int GetHashCode()
        {
            return ProjectId;
        }
    }
}
