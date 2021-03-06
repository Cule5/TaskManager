﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Task.Repositories
{
    public interface ITaskRepository
    {
        Task<Task> GetAsync(int taskId);
        System.Threading.Tasks.Task AddAsync(Core.Domain.Task.Task task);
    }
}
