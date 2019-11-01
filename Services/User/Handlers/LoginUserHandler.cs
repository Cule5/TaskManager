using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Services.Common.Query;
using Services.User.Command;
using Services.User.Query;

namespace Services.User.Handlers
{
    public class LoginUserHandler:IQueryHandler<LoginUser,JsonWebToken>
    {
        private readonly IUserService _userService = null;
        public LoginUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<JsonWebToken> HandleAsync(LoginUser query)
        {
            return await _userService.Login(query.Login, query.Password);
        }
    }
}
