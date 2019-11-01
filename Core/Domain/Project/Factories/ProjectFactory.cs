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
        public async Task<Project> CreateAsync(string projectName,string description,DateTime startDate, DateTime expectedDateOfCompletion)
        {
            var dbProject=await _projectRepository.FindAsync(projectName);
            return dbProject ?? new Project(projectName, description, startDate, expectedDateOfCompletion);
        }
    }
}
