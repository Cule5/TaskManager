﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dispatcher
{
    public interface IQueryDispatcher
    {
        System.Threading.Tasks.Task DispatchAsync();
    }
}
