﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Common.Query;
using Services.Project.Dtos;
using Services.Project.Query;

namespace Services.Project.Handlers
{
    public class UserProjectsHandler:IQueryHandler<UserProjects,IEnumerable<CommonProjectDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public UserProjectsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonProjectDto>> HandleAsync(UserProjects query)
        {
            return await _dbContext.ProjectUsers.Where(projectUser => projectUser.UserId == query.UserId)
                .Select(projectUser => new CommonProjectDto(projectUser.ProjectId, projectUser.Project.ProjectName))
                .ToListAsync();

        }
    }
}
