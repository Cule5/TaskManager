using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Task.Dtos;
using Services.Task.Query;

namespace Services.Task.Handlers
{
    public class AvailableTasksHandler:IQueryHandler<AvailableTasks,IEnumerable<CommonTaskDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public AvailableTasksHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonTaskDto>> HandleAsync(AvailableTasks query)
        {
            return await _dbContext.Tasks
                .Where(task => task.User == null)
                .Select(task =>
                new CommonTaskDto(task.TaskId, task.Description, task.TaskPriority, task.EndDate, 0))
                .ToListAsync();
        }
    }
}
