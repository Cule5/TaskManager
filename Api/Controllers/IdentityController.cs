using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher;
using Services.User.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class IdentityController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher = null;
        public IdentityController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Register")]
        public async Task<IHttpActionResult> RegisterUser(RegisterUser registerUser)
        {
            await _commandDispatcher.DispatchAsync(registerUser);
            return Ok();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Login")]
        public async Task<IHttpActionResult> LoginUser(LoginUser loginUser)
        {
            await _commandDispatcher.DispatchAsync(loginUser);
            return Ok();
        }

       
    }
}
