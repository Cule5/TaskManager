using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Task.Factories;
using Core.Domain.Task.Repositories;
using Services.Task.Dtos;

namespace Services.Task
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepository _taskRepository = null;
        private readonly ITaskFactory _taskFactory = null;
        public TaskService(ITaskRepository taskRepository,ITaskFactory taskFactory)
        {
            _taskRepository = taskRepository;
            _taskFactory = taskFactory;
        }
        public async System.Threading.Tasks.Task CreateTaskAsync(CreateTaskDto createTaskDto)
        {
            var task = await _taskFactory.CreateAsync(createTaskDto.Description,createTaskDto.TaskPriority,createTaskDto.TaskType,createTaskDto.StartDate,createTaskDto.EndDate);
            await _taskRepository.AddAsync(task);
        }

        public System.Threading.Tasks.Task DeleteTaskAsync()
        {
            throw new NotImplementedException();
        }
    }
}
