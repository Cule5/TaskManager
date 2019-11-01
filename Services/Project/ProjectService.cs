using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Project.Factories;
using Core.Domain.Project.Repositories;


namespace Services.Project
{
    public class ProjectService:IProjectService
    {
        private readonly IProjectRepository _projectRepository = null;
        private readonly IProjectFactory _projectFactory = null;
        public ProjectService(IProjectRepository projectRepository, IProjectFactory projectFactory)
        {
            _projectRepository = projectRepository;
            _projectFactory = projectFactory;
        }
        public async System.Threading.Tasks.Task CreateProjectAsync()
        {
            throw new NotImplementedException();
        }
    }
}
