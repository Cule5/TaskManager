using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Services.Dispatcher
{
    public class CommandDispatcher:ICommandDispatcher
    {
        private readonly IComponentContext _componentContext = null;

        public CommandDispatcher(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }
        public async System.Threading.Tasks.Task DispatchAsync<T>(T command) where T : ICommand
        {
            var handler = _componentContext.Resolve<ICommandHandler<T>>();
            if (handler != null)
                await handler.HandleAsync(command);
        }
    }
}
