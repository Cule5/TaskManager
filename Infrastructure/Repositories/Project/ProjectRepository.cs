using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Exceptions;
using Core.Domain.Project.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Project
{
    public class ProjectRepository:IProjectRepository
    {
        private readonly AppDbContext _dbContext = null;
        public ProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Core.Domain.Project.Project> GetAsync(int projectId)
        {
            return await _dbContext.Projects.FindAsync(projectId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Project.Project project)
        {
            var dbProject=await FindByNameAsync(project.ProjectName);
            if(dbProject!=null)
                return;
            await _dbContext.Projects.AddAsync(project);
        }

        public async Task<Core.Domain.Project.Project> FindByNameAsync(string projectName)
        {
            return await _dbContext.Projects.FirstOrDefaultAsync(p=>p.ProjectName.Equals(projectName));
        }


        public Task<IEnumerable<string>> GetAllProjects()
        {
            return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<string>>(() =>
            {
                var projects = _dbContext.Projects;
                var result = projects.Select(project => project.ProjectName).ToList();
                return result;
            });
            
        }

        
    }
}
