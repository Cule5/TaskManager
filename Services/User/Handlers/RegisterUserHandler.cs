using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Command;
using Services.User.Command;
using Services.User.Dtos;

namespace Services.User.Handlers
{
    public class RegisterUserHandler:ICommandHandler<RegisterUser>
    {
        private readonly IUserService _userService = null;
        public RegisterUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async System.Threading.Tasks.Task HandleAsync(RegisterUser command)
        {
            var registerUserDto=new RegisterUserDto()
            {
                Login = command.Login,
                Password = command.Password
            };
            await _userService.Register(registerUserDto);
        }
    }
}
