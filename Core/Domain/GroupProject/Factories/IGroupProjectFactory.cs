using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.GroupProject.Factories
{
    public interface IGroupProjectFactory
    {
        Task<GroupProject> CreateAsync(Group.Group group,Project.Project project);
    }
}
