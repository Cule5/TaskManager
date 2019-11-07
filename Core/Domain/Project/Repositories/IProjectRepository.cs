using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Project.Repositories
{
    public interface IProjectRepository
    {
        System.Threading.Tasks.Task<Project> GetAsync(int projectId);
        System.Threading.Tasks.Task AddAsync(Project project);
        System.Threading.Tasks.Task<Project> FindByName(string projectName);
        Task<IEnumerable<Project>> FindProjectsByNames(IEnumerable<string>projects);
        Task<IEnumerable<string>> GetAllProjects();

    }
}
