using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EntityFramework;
using Services.Common.Query;
using Services.Project.Query;

namespace Services.Project.Handlers
{
    public class AllProjectsHandler:IQueryHandler<AllProjects,IEnumerable<string>>
    {
        private readonly AppDbContext _dbContext = null;
        public AllProjectsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<IEnumerable<string>> HandleAsync(AllProjects query)
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
