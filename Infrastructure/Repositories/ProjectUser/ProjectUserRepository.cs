using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.ProjectUser.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.ProjectUser
{
    public class ProjectUserRepository:IProjectUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProjectUserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async System.Threading.Tasks.Task AddAsync(Core.Domain.ProjectUser.ProjectUser projectUser)
        {
            await _appDbContext.ProjectUsers.AddAsync(projectUser);
        }
    }
}
