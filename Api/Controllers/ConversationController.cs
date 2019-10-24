using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Services.Conversation.Command;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class MessagingController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public MessagingController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }
        [HttpPost]
        [Route("SendMessage")]
        public async Task<IHttpActionResult> SendMessageAsync([FromBody]SendMessage command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
