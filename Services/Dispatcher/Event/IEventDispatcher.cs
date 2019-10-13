using Services.Common.Event;

namespace Services.Dispatcher.Event
{
    public interface IEventDispatcher
    {
        System.Threading.Tasks.Task DispatchAsync<T>(params T[] events) where T : IEvent;
    }
}
