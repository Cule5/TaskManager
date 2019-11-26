using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Project.Command;
using Services.Project.Dtos;

namespace Services.Project.Handlers
{
    public class CreateProjectHandler:ICommandHandler<CreateProject>
    {
        private readonly IProjectService _projectService = null;
        public CreateProjectHandler(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public async System.Threading.Tasks.Task HandleAsync(CreateProject command)
        {
            var createProjectDto = new CreateProjectDto(command.ProjectName,command.ProjectDescription,command.StartDate,command.Users);
            await _projectService.CreateProjectAsync(createProjectDto);
        }
    }
}
