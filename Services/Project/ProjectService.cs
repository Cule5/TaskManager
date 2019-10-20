using System;
using System.Collections.Generic;
using System.Text;
using Services.Dispatcher.Event;

namespace Services.Project
{
    public class ProjectService:IProjectService
    {
        private readonly IEventDispatcher _eventDispatcher = null;
        public ProjectService(IEventDispatcher eventDispatcher)
        {
            _eventDispatcher = eventDispatcher;
        }
        public System.Threading.Tasks.Task AddProjectAsync()
        {
            throw new NotImplementedException();
        }
    }
}
