using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.WorkItem.Factories
{
    public class ReportFactory:IReportFactory
    {
        public Task<WorkItem> CreateAsync(string comment, double time, DateTime reportDate)
        {
            return System.Threading.Tasks.Task.Factory.StartNew((() => new WorkItem(comment,time,reportDate)));
        }
    }
}
