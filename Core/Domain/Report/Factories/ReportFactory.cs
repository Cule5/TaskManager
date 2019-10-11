using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Report.Factories
{
    public class ReportFactory:IReportFactory
    {
        public Task<Report> CreateAsync(string comment, double time, DateTime reportDate)
        {
            return System.Threading.Tasks.Task.Factory.StartNew((() => new Report(comment,time,reportDate)));
        }
    }
}
