using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Services.Interfaces;

namespace Services.Dispatcher
{
    public class QueryDispatcher:IQueryDispatcher
    {
        private readonly IComponentContext _componentContext = null;
        public QueryDispatcher(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }
       
        public async System.Threading.Tasks.Task DispatchAsync() 
        {
            
        }
    }
}
