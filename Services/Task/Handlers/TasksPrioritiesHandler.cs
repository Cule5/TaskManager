using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Services.Common.Query;
using Services.Task.Query;

namespace Services.Task.Handlers
{
    public class TasksPrioritiesHandler:IQueryHandler<TasksPriorities,IEnumerable<string>>
    {
        public Task<IEnumerable<string>> HandleAsync(TasksPriorities query)
        {
            return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<string>>(() => new List<string>(){ETaskPriority.Low.ToString(),ETaskPriority.BelowNormal.ToString(),ETaskPriority.Normal.ToString(),ETaskPriority.AboveNormal.ToString(),ETaskPriority.High.ToString()});
        }
    }
}
