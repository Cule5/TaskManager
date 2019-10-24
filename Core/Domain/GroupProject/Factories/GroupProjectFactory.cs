using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.GroupProject.Factories
{
    public class GroupProjectFactory:IGroupProjectFactory
    {
        public Task<GroupProject> CreateAsync(Group.Group group, Project.Project project)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(()=>new GroupProject(group,project));
        }
    }
}
