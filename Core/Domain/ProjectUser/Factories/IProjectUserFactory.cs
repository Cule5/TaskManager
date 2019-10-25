using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ProjectUser.Factories
{
    public interface IProjectUserFactory
    {
        Task<ProjectUser> CreateAsync(Project.Project project, User.User user);
    }
}
