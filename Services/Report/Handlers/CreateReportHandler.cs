using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Report.Command;

namespace Services.Report.Handlers
{
    class CreateReportHandler:ICommandHandler<CreateReport>
    {
        public System.Threading.Tasks.Task HandleAsync(CreateReport command)
        {
            throw new NotImplementedException();
        }
    }
}
