using System;
using System.Collections.Generic;
using System.Text;

namespace Services.WorkItem.Dto
{
    public class CommonWorkItemDto
    {
        public CommonWorkItemDto(string comment,double time,DateTime reportDate,int taskId)
        {
            Comment = comment;
            Time = time;
            ReportDate = reportDate;
            TaskId = taskId;
        }
        public string Comment { get; }
        public double Time { get; }
        public DateTime ReportDate { get; }
        public int TaskId { get; }
    }
}
