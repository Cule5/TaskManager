using System;
using System.Collections.Generic;
using System.Text;
using Services.Task.Dtos;

namespace Services.Task
{
    public interface ITaskService
    {
        System.Threading.Tasks.Task CreateTaskAsync(CreateTaskDto createTaskDto);
        System.Threading.Tasks.Task DeleteTaskAsync();
    }
}
