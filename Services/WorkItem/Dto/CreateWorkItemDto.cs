using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Services.WorkItem.Dto
{
    public class CreateWorkItemDto
    {
        public CreateWorkItemDto(string comment,double time,DateTime reportDate,ETaskProgress taskProgress,int taskId)
        {
            Comment = comment;
            Time = time;
            ReportDate = reportDate;
            TaskProgress = taskProgress;
            TaskId = taskId;
        }
        public string Comment { get; }
        public double Time { get; }
        public DateTime ReportDate { get; }
        public ETaskProgress TaskProgress { get; }
        public int TaskId { get; }
    }
}
