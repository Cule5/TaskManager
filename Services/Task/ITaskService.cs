using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Task
{
    public interface ITaskService
    {
        System.Threading.Tasks.Task AddTaskAsync();
        System.Threading.Tasks.Task DeleteTaskAsync();
    }
}
