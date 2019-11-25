using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.Task.Dtos;

namespace Services.Task.Query
{
    public class UserTasks:IQuery<IEnumerable<CommonTaskDto>>
    {
        public UserTasks(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; }
    }
}
