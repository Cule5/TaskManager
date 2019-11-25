using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.Group.Command;
using Services.Group.Dtos;

namespace Services.Group.Handlers
{
    public class CreateGroupHandler:ICommandHandler<CreateGroup>
    {
        private readonly IGroupService _groupService = null;
        public CreateGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public async System.Threading.Tasks.Task HandleAsync(CreateGroup command)
        {
            await _groupService.CreateGroupAsync(new CommonGroupDto(command.GroupName,command.Users));
        }
    }
}
