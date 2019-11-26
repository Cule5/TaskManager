﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Services.Task.Dtos
{
    public class CreateTaskDto
    {
        public CreateTaskDto(string description,ETaskPriority taskPriority,ETaskType taskType,DateTime startDate,DateTime endDate,int projectId)
        {
            Description = description;
            TaskPriority = taskPriority;
            TaskType = taskType;
            StartDate = startDate;
            EndDate = endDate;
            ProjectId = projectId;
        }
        public string Description { get; }
        public ETaskPriority TaskPriority { get; }
        public ETaskType TaskType { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int ProjectId { get; }
    }
}
