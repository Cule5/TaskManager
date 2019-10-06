using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Core.Domain.Common;

namespace Core.Domain.Task
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public string Description { get; set; }
        public ETaskPriority TaskPriority { get; set; }
    }
}
