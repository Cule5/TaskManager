﻿using System;
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

        [Authorize(Policy = "Common")]
        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessageAsync([FromBody]SendMessage command)
        {
            command.SenderId = UserId;
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [Authorize(Policy = "Common")]
        [HttpGet]
        [Route("UserMessages")]
        public async Task<IActionResult> UserMessages()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UserMessages(UserId)));
        }

        [Authorize(Policy = "Common")]
        [HttpGet]
        [Route("GetMessage/{conversationId}")]
        public async Task<IActionResult> GetMessage([FromRoute]int conversationId)
        {
            return Ok(await _queryDispatcher.DispatchAsync(new GetMessage(conversationId)));
        }

        [Authorize(Policy = "Common")]
        [HttpPost]
        [Route("ChangeMessageState")]
        public async Task<IActionResult> ChangeMessageState([FromBody]ChangeMessageState command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
