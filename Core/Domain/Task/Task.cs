using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Task(string description,ETaskPriority taskPriority,ETaskType taskType,DateTime startDate,DateTime endDate,Project.Project project)
        {
            Description = description;
            TaskPriority = taskPriority;
            TaskType = taskType;
            StartDate = startDate;
            EndDate = endDate;
            Project = project;
        }
        public int TaskId { get; set; }
        [Required]
        public string Description { get; set; }
        public ETaskPriority TaskPriority { get; set; }
        public ETaskType TaskType { get; set; }
        public ETaskProgress TaskProgress { get; set; } = ETaskProgress.InProgress;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RealStartDate { get; set; }
        public DateTime RealEndDate { get; set; }
        public virtual User.User User { get; set; }
        [Required]
        public virtual Project.Project Project { get; set; }
        public virtual ICollection<WorkItem.WorkItem> WorkItems { get; set; }
        
    }
}
