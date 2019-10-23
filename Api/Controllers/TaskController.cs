using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Authorize]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class TaskController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public TaskController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }
        
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public async Task<IHttpActionResult> GetAvailablesUsers()
        {
            return Ok();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("CreateTask")]
        public async Task<IHttpActionResult> CreateTask()
        {
            return Ok();
        }


    }
}
