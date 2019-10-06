using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Report.Factories
{
    public interface IReportFactory
    {
        Task<Report> CreateAsync();
    }
}
