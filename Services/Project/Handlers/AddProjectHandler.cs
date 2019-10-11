using System;
using System.Collections.Generic;
using System.Text;
using Services.Project.Command;

namespace Services.Project.Handlers
{
    public class AddProjectHandler:ICommandHandler<AddProject>
    {
        private readonly IProjectService _projectService = null;
        public AddProjectHandler(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public async System.Threading.Tasks.Task HandleAsync(AddProject command)
        {
            await _projectService.AddProjectAsync();
        }
    }
}
