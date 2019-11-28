using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.WorkItem.Command;
using Services.Task.Command;
using Services.Task.Query;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
   
    [Route("api/[controller]")]
    public class TaskController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public TaskController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }
        
        [Authorize(Policy = "ProjectManager")]
        [HttpPost]
        [Route("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody]CreateTask command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [Authorize(Policy = "Worker")]
        [HttpGet]
        [Route("UserTasks")]
        public async Task<IActionResult> UserTasks()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UserTasks(UserId)));
        }

        [Authorize(Policy = "Worker")]
        [HttpGet]
        [Route("AvailableTasks")]
        public async Task<IActionResult> AvailableTasks()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new AvailableTasks(UserId)));
        }

        [Authorize(Policy = "ProjectManager")]
        [HttpGet]
        [Route("TasksPriorities")]
        public async Task<IActionResult> TasksPriorities()
        {
            return Ok( await _queryDispatcher.DispatchAsync(new TasksPriorities()));
        }

        [Authorize(Policy = "ProjectManager")]
        [HttpGet]
        [Route("TasksTypes")]
        public async Task<IActionResult> TasksTypes()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new TasksTypes()));
        }

        [Authorize(Policy = "Worker")]
        [HttpPost]
        [Route("SetTaskToUser")]
        public async Task<IActionResult> SetTaskToUser([FromBody]int taskId)
        {
            await _commandDispatcher.DispatchAsync(new SetTaskToUser(UserId, taskId));
            return Ok();
        }

        [Authorize(Policy = "Worker")]
        [HttpGet]
        [Route("TaskProgress")]
        public async Task<IActionResult> TaskProgress()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new TaskProgress()));
        }


    }
}
