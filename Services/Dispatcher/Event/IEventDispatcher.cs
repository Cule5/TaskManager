using Services.Common.Event;

namespace Services.Dispatcher.Event
{
    public interface IEventDispatcher
    {
        System.Threading.Tasks.Task DispatchAsync<TEvent>(TEvent @event) where TEvent:IEvent;
    }
}
