using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Task.Command;

namespace Services.Task.Handlers
{
    public class SetTaskToUserHandler:ICommandHandler<SetTaskToUser>
    {
        private readonly ITaskService _taskService = null;
        public SetTaskToUserHandler(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public async System.Threading.Tasks.Task HandleAsync(SetTaskToUser command)
        {
            await _taskService.SetTaskToUserAsync(command.UserId,command.TaskId);
        }
    }
}
