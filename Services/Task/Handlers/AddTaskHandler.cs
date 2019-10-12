using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;
using Services.Task.Command;

namespace Services.Task.Handlers
{
    public class AddTaskHandler:ICommandHandler<AddTask>
    {
        private readonly ITaskService _taskService = null;
        public AddTaskHandler(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public System.Threading.Tasks.Task HandleAsync(AddTask command)
        {
            throw new NotImplementedException();
        }
    }
}
