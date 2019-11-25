using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Task.Command
{
    public class SetTaskToUser:ICommand
    {
        public SetTaskToUser(int userId,int taskId)
        {
            UserId = userId;
            TaskId = taskId;
        }
        public int UserId { get; set; }
        public int TaskId { get; set; }
    }
}
