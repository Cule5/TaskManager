using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Task.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.Task
{
    public class TaskRepository:ITaskRepository
    {
        private readonly AppDbContext _dbContext = null;
        public TaskRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Core.Domain.Task.Task> GetAsync(int taskId)
        {
            return await _dbContext.Tasks.FindAsync(taskId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Task.Task task)
        {
            await _dbContext.Tasks.AddAsync(task);
        }

    }
}
