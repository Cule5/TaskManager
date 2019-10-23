using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.User.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Authorize]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class AuthenticationController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        public AuthenticationController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("RegisterAsync")]
        public async Task<IHttpActionResult> RegisterUser([Microsoft.AspNetCore.Mvc.FromBody]RegisterUser registerUser)
        {
            await _commandDispatcher.DispatchAsync(registerUser);
            return Ok();
        }

        [AllowAnonymous]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Login")]
        public async Task<IHttpActionResult> LoginUser([Microsoft.AspNetCore.Mvc.FromBody]LoginUser loginUser)
        {
            await _commandDispatcher.DispatchAsync(loginUser);
            return Ok();
        }
        
        [Microsoft.AspNetCore.Mvc.HttpPut]
        [Microsoft.AspNetCore.Mvc.Route("Logout")]
        public async Task<IHttpActionResult> LogoutUser()
        {
            return Ok();
        }

       
    }
}
