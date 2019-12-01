using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.User.Command;
using Services.User.Dtos;

namespace Services.User.Handlers
{
    public class EditUserHandler:ICommandHandler<EditUser>
    {
        private readonly IUserService _userService = null;

        public EditUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async System.Threading.Tasks.Task HandleAsync(EditUser command)
        {
            await _userService.EditUserAsync(new ExtendedUserDto(command.UserId, command.UserType, command.Group, command.Projects));
        }
    }
}
