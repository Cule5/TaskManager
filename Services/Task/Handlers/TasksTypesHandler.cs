using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;
using Services.Common.Query;
using Services.Task.Query;

namespace Services.Task.Handlers
{
    public class TasksTypesHandler:IQueryHandler<TasksTypes,IEnumerable<string>>
    {
        public Task<IEnumerable<string>> HandleAsync(TasksTypes query)
        {
            return System.Threading.Tasks.Task.Factory.StartNew<IEnumerable<string>>(()=>new List<string>(){ETaskType.Testing.ToString(),ETaskType.Development.ToString()});
        }
    }
}
