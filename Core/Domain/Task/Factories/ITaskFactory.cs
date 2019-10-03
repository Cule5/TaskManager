using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Task.Factories
{
    public interface ITaskFactory
    {
        Task<Task> CreateAsync();
    }
}
