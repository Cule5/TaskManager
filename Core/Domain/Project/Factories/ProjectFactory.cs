using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Project.Factories
{
    public class ProjectFactory:IProjectFactory
    {
        public ProjectFactory()
        {

        }
        public Task<Project> CreateAsync(DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
}
