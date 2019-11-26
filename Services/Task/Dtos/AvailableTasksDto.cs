using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Services.Task.Dtos
{
    public class AvailableTasksDto
    {
        public AvailableTasksDto(int taskId,string description,ETaskPriority taskPriority,DateTime endDate)
        {
            TaskId = taskId;
            Description = description;
            TaskPriority = taskPriority;
            EndDate = endDate;
        }
        public int TaskId { get; }
        public string Description { get; }
        public ETaskPriority TaskPriority { get; }
        public DateTime EndDate { get; }

    }
}
