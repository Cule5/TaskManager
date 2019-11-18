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
    public class UserTasksHandler:IQueryHandler<UserTasks,IEnumerable<UserTasksDto>>
    {
        private readonly AppDbContext _dbContext;
        public UserTasksHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<UserTasksDto>> HandleAsync(UserTasks query)
        {
            return await _dbContext.Tasks
                .Where(task => task.User.UserId == query.UserId)
                .Select(task => new UserTasksDto())
                .ToListAsync();
        }
    }
}
