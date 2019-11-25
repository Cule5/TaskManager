using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.WorkItem
{
    public class WorkItem
    {
        public WorkItem()
        {

        }
        public WorkItem(string comment,double time,DateTime reportDate,Task.Task task)
        {
            Comment = comment;
            Time = time;
            ReportDate = reportDate;
        }
        public int WorkItemId { get; set; }
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        public virtual Task.Task Task { get; set; }
       
    }
}
