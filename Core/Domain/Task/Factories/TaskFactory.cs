using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;

namespace Core.Domain.Task.Factories
{
    public class TaskFactory:ITaskFactory
    {
        public Task<Task> CreateAsync(string description, ETaskPriority taskPriority, DateTime startDate, DateTime endDate)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(()=>new Task(description,taskPriority,startDate,endDate));
        }
    }
}
