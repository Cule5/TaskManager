using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Core.Domain.Task.Repositories;
using Core.Domain.WorkItem.Factories;
using Core.Domain.WorkItem.Repositories;
using Infrastructure.UnitOfWork;
using Services.WorkItem.Dto;

namespace Services.WorkItem
{
    public class WorkItemService : IWorkItemService
    {
        private readonly IWorkItemRepository _workItemRepository = null;
        private readonly ITaskRepository _taskRepository = null;
        private readonly IWorkItemFactory _workItemFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public WorkItemService(IWorkItemRepository workItemRepository, ITaskRepository taskRepository, IWorkItemFactory workItemFactory, IUnitOfWork unitOfWork)
        {
            _workItemRepository = workItemRepository;
            _taskRepository = taskRepository;
            _workItemFactory = workItemFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateWorkItemAsync(CreateWorkItemDto createWorkItemDto)
        {
            var dbTask = await _taskRepository.GetAsync(createWorkItemDto.TaskId);
            if (dbTask == null)
                throw new Exception("");
            if(dbTask.TaskProgress==ETaskProgress.Finished)
                throw new Exception("");
            dbTask.TaskProgress = createWorkItemDto.TaskProgress;
            var workItem = await _workItemFactory.CreateAsync(createWorkItemDto.Comment, createWorkItemDto.Time, createWorkItemDto.ReportDate, dbTask);
            await _workItemRepository.AddAsync(workItem);
            await _unitOfWork.SaveAsync();


        }
    }
}
