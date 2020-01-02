using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.User.Dtos;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class ProjectsManagersHandler:IQueryHandler<ProjectsManagers,IEnumerable<CommonUserDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public ProjectsManagersHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonUserDto>> HandleAsync(ProjectsManagers query)
        {
            return await _dbContext.Users.Where(user => user.Account.UserType == EUserType.CompanyAdmin).Select(user =>
                new CommonUserDto(user.UserId, user.Name, user.LastName, user.Account.Email)).ToListAsync();
        }
    }
}
