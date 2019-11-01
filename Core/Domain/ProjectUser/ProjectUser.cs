using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ProjectUser
{
    public class ProjectUser
    {
        public ProjectUser()
        {

        }
        public ProjectUser(Project.Project project,User.User user)
        {
            Project = project;
            User = user;
        }
        public int ProjectId { get; set; }
        public virtual Project.Project Project { get; set; }
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
    }
}
