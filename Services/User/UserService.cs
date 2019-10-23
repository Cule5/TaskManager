using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.User.Factories;
using Core.Domain.User.Repositories;
using Infrastructure.Authentication;
using Services.Exceptions;
using Services.User.Dtos;

namespace Services.User
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository = null;
        private readonly IUserFactory _userFactory = null;
        private readonly IJwtProvider _jwtProvider = null;
        public UserService(IUserRepository userRepository,IUserFactory userFactory,IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
            _jwtProvider = jwtProvider;
        }
        public async System.Threading.Tasks.Task<JsonWebToken> Login(string login,string password)
        {
            var dbUser = await _userRepository.FindAsync(login,password);
            if(dbUser==null)
                throw new LoginPasswordException("Bad login or password");

            _jwtProvider.CreateToken(dbUser.UserId);

            return null;

        }

        public System.Threading.Tasks.Task Logout()
        {
            
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task RegisterAsync(RegisterUserDto registerUserDto)
        {
            var newUser=await _userFactory.CreateAsync(registerUserDto.Login, registerUserDto.Password);
            await _userRepository.AddAsync(newUser);
        }
    }
}
