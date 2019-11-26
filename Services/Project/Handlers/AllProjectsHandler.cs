using System;
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
    public class AllProjectsHandler:IQueryHandler<AllProjects,IEnumerable<CommonProjectDto>>
    {
        private readonly AppDbContext _dbContext = null;
        public AllProjectsHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CommonProjectDto>> HandleAsync(AllProjects query)
        {
            return await _dbContext.Projects.Select(project => new CommonProjectDto(project.ProjectId,project.ProjectName)).ToListAsync();
        }
    }
}
