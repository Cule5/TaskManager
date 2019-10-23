using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Command;

namespace Services.Task.Command
{
    public class CreateTask:ICommand
    {
        public string Description { get; set; }
        public ETaskPriority TaskPriority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
