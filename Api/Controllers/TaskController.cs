using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.Report.Command;
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

        [HttpPost]
        [Route("CreateReport")]
        public async Task<IActionResult> CreateReport([FromBody]CreateReport command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpGet]
        [Route("UserTasks")]
        public async Task<IActionResult> UserTasks()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UserTasks(UserId)));
        }


    }
}
