using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Project.Dtos;

namespace Services.Project
{
    public interface IProjectService
    {
        System.Threading.Tasks.Task CreateProjectAsync(CreateProjectDto createProjectDto);
        Task<IEnumerable<string>> AllProjectsAsync();
    }
}
