using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.Group;
using Services.Group.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        private readonly IGroupService _groupService = null;
        public GroupController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher,IGroupService groupService)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _groupService = groupService;
        }
        [Authorize(Policy = "CompanyAdmin")]
        [HttpPost]
        [Route("CreateGroup")]
        public async Task<IActionResult> CreateGroup([FromBody]CreateGroup command)
        {
            var u = base.User.Identity.Name;
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpGet]
        [Route("AllGroups")]
        public async Task<IActionResult> AllGroups()
        {
            return Ok(await _groupService.AllGroups());
        }
       
    }
}
