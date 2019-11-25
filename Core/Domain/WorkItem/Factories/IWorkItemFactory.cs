using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.WorkItem.Factories
{
    public interface IWorkItemFactory
    {
        Task<WorkItem> CreateAsync(string comment,double time,DateTime reportDate,Task.Task task);
    }
}
