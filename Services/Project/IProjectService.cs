using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Project
{
    public interface IProjectService
    {
        System.Threading.Tasks.Task CreateProjectAsync();
        Task<IEnumerable<string>> AllProjectsAsync();
    }
}
