using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.User.Command;
using Services.User.Query;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        public UserController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser([FromBody]RegisterUser command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [AllowAnonymous]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Login")]
        public async Task<IActionResult> LoginUser([FromBody]LoginUser query)
        {
            try
            {
                return Ok(await _queryDispatcher.DispatchAsync(query));
            }
            catch (Exception ex)
            {
                return Ok();
            }

        }
        
        [HttpPut]
        [Route("Logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            return Ok();
        }

       
    }
}
