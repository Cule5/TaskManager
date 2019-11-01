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
        public WorkItem(string comment,double time,DateTime reportDate)
        {
            Comment = comment;
            Time = time;
            ReportDate = reportDate;
        }
        public int WorkItemID { get; set; }
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        public virtual Task.Task Task { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as WorkItem);
        }
        public virtual bool Equals(WorkItem workItem)
        {
            if (workItem == null)
                return false;
            if (object.ReferenceEquals(this, workItem))
                return true;

            return true;
        }

        public override int GetHashCode()
        {
            return WorkItemID;
        }
    }
}
