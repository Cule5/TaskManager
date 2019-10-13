using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Command;

namespace Services.Dispatcher.Command
{
    public interface ICommandDispatcher
    {
        System.Threading.Tasks.Task DispatchAsync<T>(T command) where T : ICommand;
    }
}
