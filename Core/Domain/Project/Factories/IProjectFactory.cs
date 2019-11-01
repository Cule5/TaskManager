using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project.Factories
{
    public interface IProjectFactory
    {
        System.Threading.Tasks.Task<Project> CreateAsync(string projectName,string description,DateTime startDate,DateTime expectedDateOfCompletion);
    }
}
