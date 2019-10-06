using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Project.Repositories
{
    public interface IProjectRepository
    {
        System.Threading.Tasks.Task<Project> GetAsync(Guid projectId);
        System.Threading.Tasks.Task AddAsync(Project project);
        System.Threading.Tasks.Task<Project> FindAsync(Project project);

    }
}
