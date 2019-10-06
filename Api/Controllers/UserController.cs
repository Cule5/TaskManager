using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher;
using Services.User.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        public UserController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(RegisterUser registerUser)
        {
            await _commandDispatcher.DispatchAsync(registerUser);
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUser(LoginUser loginUser)
        {
            await _commandDispatcher.DispatchAsync(loginUser);
            return Ok();
        }

       
    }
}
