using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Conversation.Command;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Microsoft.AspNetCore.Authorization;
using Services.Conversation.Query;
using Task = Core.Domain.Task.Task;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ConversationController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public ConversationController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessageAsync([FromBody]SendMessage command)
        {
            command.SenderId = UserId;
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpGet]
        [Route("UserMessages")]
        public async Task<IActionResult> UserMessages()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UserMessages(UserId)));
        }
    }
}
