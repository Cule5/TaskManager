﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Dispatcher.Command;
using Services.Dispatcher.Query;
using Services.Project;
using Services.Project.Command;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
   
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly ICommandDispatcher _commandDispatcher=null;
        private readonly IQueryDispatcher _queryDispatcher = null;
        private readonly IProjectService _projectService = null;
        public ProjectController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher,IProjectService projectService)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _projectService = projectService;
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpPost]
        [Route("CreateProject")]
        public async Task<IActionResult> CreateProject([Microsoft.AspNetCore.Mvc.FromBody]CreateProject command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [Authorize(Policy = "CompanyAdmin")]
        [HttpGet]
        [Route("AllProjects")]
        public async Task<IActionResult> AllProjects()
        {
            return Ok(await _projectService.AllProjectsAsync());
        }


    }
}
