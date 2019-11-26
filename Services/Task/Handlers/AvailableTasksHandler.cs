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
    public class AvailableTasksHandler:IQueryHandler<AvailableTasks,IEnumerable<AvailableTasksDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public AvailableTasksHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<AvailableTasksDto>> HandleAsync(AvailableTasks query)
        {
            return await _dbContext.Tasks.Join(_dbContext.Projects, task => task.Project.ProjectId, project => project.ProjectId,
                (task, project) => new
                {
                    TaskId = task.TaskId,
                    Description = task.Description,
                    TaskPriority = task.TaskPriority,
                    EndDate = task.EndDate,
                    User=task.User,
                    ProjectId=project.ProjectId
                })
                .Where(a=>a.User==null)
                .Select(a => new AvailableTasksDto(a.TaskId, a.Description, a.TaskPriority, a.EndDate)).ToListAsync();



        }
    }
}
