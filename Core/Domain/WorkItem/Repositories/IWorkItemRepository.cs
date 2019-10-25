using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Core.Domain.WorkItem.Repositories
{
    public interface IWorkItemRepository
    {
        Task<WorkItem> GetAsync(int reportId);
        System.Threading.Tasks.Task AddAsync(WorkItem workItem);
        Task<WorkItem> FindAsync(WorkItem workItem);
    }
}
