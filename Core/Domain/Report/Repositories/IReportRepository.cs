using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Core.Domain.Report.Repositories
{
    public interface IReportRepository
    {
        Task<Report> GetAsync(Guid id);
        System.Threading.Tasks.Task AddAsync(Report report);
        Task<Report> FindAsync(Report report);
    }
}
