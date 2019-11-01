using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.Project.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class ProjectController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher=null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public ProjectController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        public async Task<IHttpActionResult> CreateProjectAsync([FromBody]CreateProject command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }
    }
}
