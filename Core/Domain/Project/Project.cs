using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Project
{
    public class Project
    {
        public Guid ProjectId { get; set; }


        public ICollection<Task.Task> Tasks { get; set; }
    }
}
