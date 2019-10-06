using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Project.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.Project
{
    public class ProjectRepository:IProjectRepository
    {
        private readonly AppDbContext _dbContext = null;
        public ProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Core.Domain.Project.Project> GetAsync(Guid projectId)
        {
            return await _dbContext.Projects.FindAsync(projectId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Project.Project project)
        {
            await _dbContext.Projects.AddAsync(project);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Project.Project> FindAsync(Core.Domain.Project.Project project)
        {
            throw new NotImplementedException();
        }
    }
}
