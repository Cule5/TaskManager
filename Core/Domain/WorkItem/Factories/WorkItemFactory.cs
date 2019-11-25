using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.WorkItem.Factories
{
    public class WorkItemFactory:IWorkItemFactory
    {
        public Task<WorkItem> CreateAsync(string comment, double time, DateTime reportDate,Task.Task task)
        {
            return System.Threading.Tasks.Task.Factory.StartNew((() => new WorkItem(comment,time,reportDate,task)));
        }
    }
}
