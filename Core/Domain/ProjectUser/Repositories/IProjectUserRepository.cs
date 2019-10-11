using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ProjectUser.Repositories
{
    public interface IProjectUserRepository
    {
        System.Threading.Tasks.Task AddAsync(ProjectUser projectUser);
    }
}
