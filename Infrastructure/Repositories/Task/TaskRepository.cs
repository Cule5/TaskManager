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

        public async Task<Core.Domain.Task.Task> GetAsync(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Task.Task task)
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Task.Task> FindAsync(Core.Domain.Task.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
