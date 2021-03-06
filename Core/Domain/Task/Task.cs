﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Core.Domain.Common;
using Core.Domain.Report;

namespace Core.Domain.Task
{
    public class Task
    {
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
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
        public virtual ICollection<WorkItem> WorkItems { get; set; }
        public override int GetHashCode()
        {
            return TaskId;
        }
    }
}
