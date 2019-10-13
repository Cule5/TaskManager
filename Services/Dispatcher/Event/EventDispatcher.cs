using System;
using Autofac;
using Services.Common.Event;

namespace Services.Dispatcher.Event
{
    public class EventDispatcher:IEventDispatcher
    {
        private readonly IComponentContext _componentContext = null;
        public EventDispatcher(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }
        public System.Threading.Tasks.Task DispatchAsync<TEvent>(TEvent @event) where TEvent : IEvent
        {
            throw new NotImplementedException();
        }
    }
}
