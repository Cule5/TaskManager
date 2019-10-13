using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;

namespace Services.Dispatcher
{
    public interface IQueryDispatcher
    {
        System.Threading.Tasks.Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query);
    }
}
