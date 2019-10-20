using System;
using System.Linq;
using System.Reflection;
using Autofac;
using Services.Common.Event;

namespace Services.Dispatcher.Event
{
    public class EventDispatcher : IEventDispatcher
    {
        private readonly IComponentContext _componentContext = null;

        public EventDispatcher(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public async System.Threading.Tasks.Task DispatchAsync<T>(params T[] events) where T : IEvent
        {
            foreach (var @event in events)
            {
                if (@event == null)
                    throw new ArgumentNullException(nameof(@event), "Event can not be null.");

                var eventType = @event.GetType();
                var handlerType = typeof(IEventHandler<>).MakeGenericType(eventType);
                _componentContext.TryResolve(handlerType, out var handler);

                if (handler == null)
                    return;

                var method = handler.GetType()
                    .GetRuntimeMethods()
                    .First(x => x.Name.Equals("HandleAsync"));

                await (System.Threading.Tasks.Task) ((dynamic) handler).HandleAsync(@event);
            }
        }
    }
}
