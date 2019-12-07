using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Project.Repositories;
using Core.Domain.Task.Factories;
using Core.Domain.Task.Repositories;
using Core.Domain.User.Repositories;
using Infrastructure.UnitOfWork;
using Services.Task.Dtos;

namespace Services.Task
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepository _taskRepository = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IProjectRepository _projectRepository = null;
        private readonly ITaskFactory _taskFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public TaskService(ITaskRepository taskRepository,IUserRepository userRepository,IProjectRepository projectRepository,ITaskFactory taskFactory,IUnitOfWork unitOfWork)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _projectRepository = projectRepository;
            _taskFactory = taskFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateTaskAsync(CreateTaskDto createTaskDto)
        {
            var dbProject=await _projectRepository.GetAsync(createTaskDto.ProjectId);
            if(dbProject==null)
                throw new Exception("Given project does not exists");
            var task = await _taskFactory.CreateAsync(createTaskDto.Description,createTaskDto.TaskPriority,createTaskDto.TaskType,createTaskDto.StartDate,createTaskDto.EndDate,dbProject);
            await _taskRepository.AddAsync(task);
            await _unitOfWork.SaveAsync();
        }

        public async System.Threading.Tasks.Task SetTaskToUserAsync(int userId, int taskId)
        {
            var task = await _taskRepository.GetAsync(taskId);
            if (task.User != null) 
                throw new Exception("");
            var user = await _userRepository.GetAsync(userId);
            
            user.Tasks.Add(task);
            task.User = user;
            task.RealStartDate=DateTime.Now;
            await _unitOfWork.SaveAsync();
        }
    }
}
