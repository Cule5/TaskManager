using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Task.Dtos;

namespace Services.Task.Query
{
    public class AvailableTasks:IQuery<IEnumerable<CommonTaskDto>>
    {
        public AvailableTasks(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; }
    }
}
