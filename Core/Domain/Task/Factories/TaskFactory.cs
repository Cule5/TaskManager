using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Task.Factories
{
    public class TaskFactory:ITaskFactory
    {
        public async Task<Task> CreateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
