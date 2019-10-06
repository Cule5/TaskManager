using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.User.Command;

namespace Services.User.Handlers
{
    public class RegisterUserHandler:ICommandHandler<RegisterUser>
    {
        private readonly IUserService _userService = null;
        public RegisterUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task HandleAsync(RegisterUser command)
        {
            throw new NotImplementedException();
        }
    }
}
