using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class BaseController:Controller
    {
        protected int UserId => Convert.ToInt32(User.Identity.Name);
    }
}
