using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Core.Domain.Common;
using Core.Domain.WorkItem;

namespace Core.Domain.Task
{
    public class Task
    {
        public Task()
        {

        }
        public Task(string description,ETaskPriority taskPriority,DateTime startDate,DateTime endDate)
        {
            Description = description;
            TaskPriority = taskPriority;
            StartDate = startDate;
            EndDate = endDate;
        }
        public int TaskId { get; set; }
        public string Description { get; set; }
        public ETaskPriority TaskPriority { get; set; }
        public ETaskType TaskType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual User.User User { get; set; }
        public virtual ICollection<WorkItem.WorkItem> WorkItems { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Task);
        }

        public virtual bool Equals(Task task)
        {
            if (task == null)
                return false;
            return task.Description.Equals(Description)&&task.TaskPriority==TaskPriority&&task.TaskType==TaskType&&task.StartDate==StartDate&&task.EndDate==EndDate;
        }
        public override int GetHashCode()
        {
            return TaskId;
        }
    }
}
