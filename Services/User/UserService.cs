using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Services.User.Dtos;

namespace Services.User
{
    public class UserService:IUserService
    {
        private readonly IJwtProvider _jwtProvider = null;
        public UserService(IJwtProvider jwtProvider)
        {
            _jwtProvider = jwtProvider;
        }
        public async System.Threading.Tasks.Task<JsonWebToken> Login(string login,string password)
        {
            return null;

        }

        public System.Threading.Tasks.Task Logout()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Register(RegisterUserDto registerUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
