using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project.Repositories
{
    public interface IProjectRepository
    {
        System.Threading.Tasks.Task AddAsync();

        System.Threading.Tasks.Task<Project> FindAsync(Project project);

    }
}
