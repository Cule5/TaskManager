using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Account.Factories;
using Core.Domain.Account.Repositories;
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
        private readonly IAccountRepository _accountRepository = null;
        private readonly IUserFactory _userFactory = null;
        private readonly IAccountFactory _accountFactory = null;
        private readonly IJwtProvider _jwtProvider = null;
        public UserService(IUserRepository userRepository,IAccountRepository accountRepository,IUserFactory userFactory,IAccountFactory accountFactory,IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _userFactory = userFactory;
            _accountFactory = accountFactory;
            _jwtProvider = jwtProvider;
        }
        public async System.Threading.Tasks.Task<JsonWebToken> Login(string login,string password)
        {
            var dbUser = await _accountRepository.FindAsync(login);
            if(dbUser==null)
                throw new LoginPasswordException("Bad login or password");

            //_jwtProvider.CreateToken(dbUser.UserId);

            return null;

        }

        public System.Threading.Tasks.Task LogoutAsync()
        {
            
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task RegisterAsync(RegisterUserDto registerUserDto)
        {
            var newAccount = await _accountFactory.CreateAsync(registerUserDto.Login, registerUserDto.Password);
            var newUser=await _userFactory.CreateAsync(registerUserDto.Login, registerUserDto.Password,registerUserDto.UserType,newAccount);
            await _userRepository.AddAsync(newUser);
            await _accountRepository.AddAsync(newAccount);
        }

        public async Task<IEnumerable<Core.Domain.User.User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
    }
}
