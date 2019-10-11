using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project
{
    public class Project
    {
        public Project(string projectName,DateTime startDate)
        {
            ProjectName = projectName;
            StartDate = startDate;
        }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public virtual ICollection<User.User> Users { get; set; }
        public virtual ICollection<Task.Task> Tasks { get; set; }
    }
}
