﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;

namespace Core.Domain.Task.Factories
{
    public interface ITaskFactory
    {
        Task<Task> CreateAsync(string description,ETaskPriority taskPriority,DateTime startDate,DateTime endDate);
    }
}
