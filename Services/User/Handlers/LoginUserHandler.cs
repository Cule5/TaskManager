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
        public Task HandleAsync(LoginUser command)
        {
            throw new NotImplementedException();
        }
    }
}
