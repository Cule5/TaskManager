using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.WorkItem.Command;

namespace Services.WorkItem.Handlers
{
    class CreateReportHandler:ICommandHandler<CreateWorkItem>
    {
        public System.Threading.Tasks.Task HandleAsync(CreateWorkItem command)
        {
            throw new NotImplementedException();
        }
    }
}
