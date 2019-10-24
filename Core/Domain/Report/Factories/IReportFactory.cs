using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Report.Factories
{
    public interface IReportFactory
    {
        Task<WorkItem> CreateAsync(string comment,double time,DateTime reportDate);
    }
}
