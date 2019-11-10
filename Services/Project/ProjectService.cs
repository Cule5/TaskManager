using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Project.Factories;
using Core.Domain.Project.Repositories;
using Infrastructure.UnitOfWork;
using Services.Project.Dtos;


namespace Services.Project
{
    public class ProjectService:IProjectService
    {
        private readonly IProjectRepository _projectRepository = null;
        private readonly IProjectFactory _projectFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public ProjectService(IProjectRepository projectRepository, IProjectFactory projectFactory,IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _projectFactory = projectFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateProjectAsync(CreateProjectDto createProjectDto)
        {
            var newProject=await _projectFactory.CreateAsync(createProjectDto.ProjectName,createProjectDto.Description,createProjectDto.StartDate);
            await _projectRepository.AddAsync(newProject);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<string>> AllProjectsAsync()
        {
            return await _projectRepository.GetAllProjects();
        }
    }
}
