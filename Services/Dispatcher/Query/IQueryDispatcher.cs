using Services.Common.Query;

namespace Services.Dispatcher.Query
{
    public interface IQueryDispatcher
    {
        System.Threading.Tasks.Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query);
    }
}
