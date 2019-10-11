using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Project.Repositories;

namespace Core.Domain.Project.Factories
{
    public class ProjectFactory:IProjectFactory
    {
        private readonly IProjectRepository _projectRepository = null;
        public ProjectFactory(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public Task<Project> CreateAsync(string projectName,DateTime startDate)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(() => new Project(projectName,startDate));
        }
    }
}
