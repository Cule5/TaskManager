using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            Task = task;
        }
        public int WorkItemId { get; set; }
        [Required]
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        [Required]
        public virtual Task.Task Task { get; set; }
       
    }
}
