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
        public async Task<Core.Domain.Report.Report> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Report.Report report)
        {
            throw new NotImplementedException();
        }

        public async Task<Core.Domain.Report.Report> FindAsync(Core.Domain.Report.Report report)
        {
            throw new NotImplementedException();
        }
    }
}
