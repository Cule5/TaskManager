using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;

namespace Core.Domain.Task.Factories
{
    public class TaskFactory:ITaskFactory
    {
        public Task<Task> CreateAsync(string description, ETaskPriority taskPriority,ETaskType taskType ,DateTime startDate, DateTime endDate,Project.Project project)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(()=>new Task(description,taskPriority,taskType,startDate,endDate,project));
        }
    }
}
