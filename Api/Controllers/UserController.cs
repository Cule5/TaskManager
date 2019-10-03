﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUser()
        {
            return Ok();
        }

       
    }
}
