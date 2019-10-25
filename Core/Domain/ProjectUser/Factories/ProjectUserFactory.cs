using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ProjectUser.Factories
{
    public class ProjectUserFactory:IProjectUserFactory
    {
        public Task<ProjectUser> CreateAsync(Project.Project project,User.User user)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(()=>new ProjectUser(project,user));
        }
    }
}
