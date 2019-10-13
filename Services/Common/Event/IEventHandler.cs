namespace Services.Common.Event
{
    public interface IEventHandler<TEvent> where TEvent:IEvent
    {
        System.Threading.Tasks.Task HandleAsync(TEvent @event);
    }
}
