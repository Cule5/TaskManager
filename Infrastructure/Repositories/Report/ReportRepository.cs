using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Report.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.Report
{
    public class ReportRepository:IReportRepository
    {
        private readonly AppDbContext _dbContext = null;
        public ReportRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Core.Domain.Report.Report> GetAsync(int reportId)
        {
            return await _dbContext.Reports.FindAsync(reportId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Report.Report report)
        {
            await _dbContext.AddAsync(report);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Report.Report> FindAsync(Core.Domain.Report.Report report)
        {
            throw new NotImplementedException();
        }
    }
}
