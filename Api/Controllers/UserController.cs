using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.User;
using Services.User.Command;
using Services.User.Query;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        private readonly IUserService _userService = null;
        public UserController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher,IUserService userService)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _userService = userService;
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
        [HttpPost]
        [Route("Login")]
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


        [Authorize(Policy = "CompanyAdmin")]
        [HttpGet]
        [Route("UsersTypes")]
        public async Task<IActionResult> UsersTypes()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new AllUsersTypes()));
        }

        [HttpPost]
        [Route("FindUser")]
        public async Task<IActionResult> FindUser([FromBody]FindUser query)
        {
            return Ok(await _queryDispatcher.DispatchAsync(query));
        }


        [HttpPost]
        [Route("UserInfo{userId}")]
        public async Task<IActionResult> UserInfo([FromRoute]int userId)
        {
            return Ok();
        }


    }
}
