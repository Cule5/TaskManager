using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.User.Command;

namespace Services.User.Handlers
{
    public class LoginUserHandler:ICommandHandler<LoginUser>
    {
        private readonly IUserService _userService = null;
        public LoginUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async System.Threading.Tasks.Task HandleAsync(LoginUser command)
        {
            await _userService.Login(command.Login,command.Password);
        }
    }
}
