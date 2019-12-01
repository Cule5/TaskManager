using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ProjectUser.Repositories
{
    public interface IProjectUserRepository
    {
        System.Threading.Tasks.Task AddAsync(ProjectUser projectUser);
        System.Threading.Tasks.Task DeleteAsync(ProjectUser projectUser);
    }
}
