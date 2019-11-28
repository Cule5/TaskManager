using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.WorkItem.Command;
using Services.WorkItem.Dto;

namespace Services.WorkItem.Handlers
{
    class CreateWorkItemHandler:ICommandHandler<CreateWorkItem>
    {
        private readonly IWorkItemService _workItemService = null;
        public CreateWorkItemHandler(IWorkItemService workItemService)
        {
            _workItemService = workItemService;
        }
        public async System.Threading.Tasks.Task HandleAsync(CreateWorkItem command)
        {
            await _workItemService.CreateWorkItemAsync(new CreateWorkItemDto(command.Comment, command.Time,
                command.ReportDate,command.TaskProgress, command.TaskId));
        }
    }
}
