using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.WorkItem.Command;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    public class WorkItemController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public WorkItemController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [Authorize(Policy = "Worker")]
        [HttpPost]
        [Route("CreateWorkItem")]
        public async Task<IActionResult> CreateReport([Microsoft.AspNetCore.Mvc.FromBody]CreateWorkItem command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
