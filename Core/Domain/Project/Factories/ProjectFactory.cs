using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Exceptions;
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
        public async Task<Project> CreateAsync(string projectName,string description,DateTime startDate)
        {
            var dbProject=await _projectRepository.FindByNameAsync(projectName);
            if(dbProject!=null)
                throw new ProjectNameException("Project with given name already exists");
            return new Project(projectName, description, startDate);
        }
    }
}
