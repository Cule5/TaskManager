using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Group.Command;

namespace Services.Group.Handlers
{
    public class CreateGroupHandler:ICommandHandler<CreateGroup>
    {
        public System.Threading.Tasks.Task HandleAsync(CreateGroup command)
        {
            throw new NotImplementedException();
        }
    }
}
