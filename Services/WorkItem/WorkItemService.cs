using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Task.Repositories;
using Core.Domain.WorkItem.Factories;
using Core.Domain.WorkItem.Repositories;
using Infrastructure.UnitOfWork;
using Services.WorkItem.Dto;

namespace Services.WorkItem
{
    public class WorkItemService:IWorkItemService
    {
        private readonly IWorkItemRepository _workItemRepository = null;
        private readonly ITaskRepository _taskRepository = null;
        private readonly IWorkItemFactory _workItemFactory = null;
        private readonly IUnitOfWork _unitOfWork=null;
        public WorkItemService(IWorkItemRepository workItemRepository,ITaskRepository taskRepository,IWorkItemFactory workItemFactory,IUnitOfWork unitOfWork)
        {
            _workItemRepository = workItemRepository;
            _taskRepository = taskRepository;
            _workItemFactory = workItemFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateWorkItemAsync(CommonWorkItemDto commonWorkItemDto)
        {
            var dbTask=await _taskRepository.GetAsync(commonWorkItemDto.TaskId);
            if (dbTask != null)
            {
                var workItem = await _workItemFactory.CreateAsync(commonWorkItemDto.Comment, commonWorkItemDto.Time, commonWorkItemDto.ReportDate,dbTask);
                await _workItemRepository.AddAsync(workItem);
                await _unitOfWork.SaveAsync();
            }
            
        }
    }
}
