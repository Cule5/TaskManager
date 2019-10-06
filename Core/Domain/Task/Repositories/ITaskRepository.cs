using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Task.Repositories
{
    public interface ITaskRepository
    {
        Task<Task> GetAsync(Guid taskId);
        System.Threading.Tasks.Task AddAsync(Core.Domain.Task.Task task);
        Task<Task> FindAsync(Core.Domain.Task.Task task);
    }
}
