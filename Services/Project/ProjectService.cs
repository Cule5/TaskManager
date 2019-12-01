using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Project.Factories;
using Core.Domain.Project.Repositories;
using Core.Domain.ProjectUser.Factories;
using Core.Domain.ProjectUser.Repositories;
using Core.Domain.User.Repositories;
using Infrastructure.UnitOfWork;
using Services.Project.Dtos;
using Services.User.Dtos;


namespace Services.Project
{
    public class ProjectService:IProjectService
    {
        private readonly IProjectRepository _projectRepository = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IProjectUserRepository _projectUserRepository=null;
        private readonly IProjectFactory _projectFactory = null;
        private readonly IProjectUserFactory _projectUserFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        
        public ProjectService(IProjectRepository projectRepository, IUserRepository userRepository, IProjectUserRepository projectUserRepository,IProjectFactory projectFactory,IProjectUserFactory projectUserFactory,IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _projectUserRepository = projectUserRepository;
            _userRepository = userRepository;
            _projectFactory = projectFactory;
            _projectUserFactory = projectUserFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateProjectAsync(CreateProjectDto createProjectDto)
        {
            var newProject = await _projectFactory.CreateAsync(createProjectDto.ProjectName, createProjectDto.Description, createProjectDto.StartDate);
            foreach (var user in createProjectDto.Users?? Enumerable.Empty<CommonUserDto>())
            {
                var dbUser=await _userRepository.GetAsync(user.UserId);
                if (dbUser == null) continue;
                var newProjectUser = await _projectUserFactory.CreateAsync(newProject, dbUser);
                dbUser.ProjectUsers.Add(newProjectUser);
                newProject.ProjectUsers.Add(newProjectUser);
                await _projectUserRepository.AddAsync(newProjectUser);
            }
            
            await _projectRepository.AddAsync(newProject);
            await _unitOfWork.SaveAsync();
        }
    }
}
