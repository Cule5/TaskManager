using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Project.Factories
{
    public class ProjectFactory:IProjectFactory
    {
        public Task<Project> CreateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
