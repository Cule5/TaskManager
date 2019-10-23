using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Task.Command;

namespace Services.Task.Handlers
{
    public class CreateTaskHandler:ICommandHandler<CreateTask>
    {
        private readonly ITaskService _taskService = null;
        public CreateTaskHandler(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public async System.Threading.Tasks.Task HandleAsync(CreateTask command)
        {
            await _taskService.CreateTaskAsync();
        }
    }
}
