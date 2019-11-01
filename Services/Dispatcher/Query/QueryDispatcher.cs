using System;
using System.Threading.Tasks;
using Autofac;
using Services.Common.Command;
using Services.Common.Query;

namespace Services.Dispatcher.Query
{
    public class QueryDispatcher:IQueryDispatcher
    {
        private readonly IComponentContext _componentContext = null;
        public QueryDispatcher(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }
        public async Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query)
        {
            Type type = typeof(IQueryHandler<,>);
            Type[] typeArgs = { query.GetType(), typeof(TResult) };
            Type handlerType = type.MakeGenericType(typeArgs);

            dynamic handler = _componentContext.Resolve(handlerType);

            if (handler == null)
            {
                throw new ArgumentException($"Query handler: '{typeof(IQuery<TResult>).Name}' was not found.");
            }

            return await handler.HandleAsync((dynamic)query);
        }
    }
}
