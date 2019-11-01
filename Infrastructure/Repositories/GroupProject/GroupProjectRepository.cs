using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.GroupProject.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.GroupProject
{
    public class GroupProjectRepository:IGroupProjectRepository
    {
        private readonly AppDbContext _dbContext=null;
        public GroupProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async System.Threading.Tasks.Task AddAsync(Core.Domain.GroupProject.GroupProject groupProject)
        {
            //await _dbContext.GroupProjects.AddAsync(groupProject);
            await _dbContext.SaveChangesAsync();
        }
    }
}
