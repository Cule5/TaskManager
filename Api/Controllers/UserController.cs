﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.RefreshToken.Command;
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
            return Ok(await _queryDispatcher.DispatchAsync(query));
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

        [Authorize(Policy = "CompanyAdmin")]
        [HttpGet]
        [Route("UserInfo/{userId}")]
        public async Task<IActionResult> UserInfo([FromRoute]int userId)
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UserInfo(userId)));
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpGet]
        [Route("UsersWithoutGroup")]
        public async Task<IActionResult> UsersWithoutGroup()
        {
            return Ok(await _queryDispatcher.DispatchAsync(new UsersWithoutGroup()));
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpPost]
        [Route("EditUser")]
        public async Task<IActionResult> EditUser([FromBody]EditUser command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [Authorize(Policy = "Common")]
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody]RefreshToken command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }


    }
}
