using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Task.Dtos;
using Services.Task.Query;

namespace Services.Task.Handlers
{
    public class UserTasksHandler:IQueryHandler<UserTasks,IEnumerable<CommonTaskDto>>
    {
        private readonly AppDbContext _dbContext;
        public UserTasksHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonTaskDto>> HandleAsync(UserTasks query)
        {
            return await _dbContext.Tasks
                .Where(task => task.User!=null&&task.User.UserId==query.UserId&&task.TaskProgress==ETaskProgress.InProgress)
                .Select(task => new CommonTaskDto(task.TaskId,task.Description,task.TaskPriority,task.EndDate,task.WorkItems
                    .Sum(workItem=>workItem.Time)))
                .ToListAsync();
        }
    }
}
