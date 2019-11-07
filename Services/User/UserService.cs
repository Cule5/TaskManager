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
using System.Web;
using Core.Domain.Group.Repositories;
using Core.Domain.Project.Repositories;
using Core.Domain.ProjectUser.Factories;
using Core.Domain.ProjectUser.Repositories;

namespace Services.User
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository = null;
        private readonly IAccountRepository _accountRepository = null;
        private readonly IUserFactory _userFactory = null;
        private readonly IAccountFactory _accountFactory = null;
        private readonly IJwtProvider _jwtProvider = null;
        private readonly IGroupRepository _groupRepository = null;
        private readonly IProjectRepository _projectRepository = null;
        private readonly IProjectUserRepository _projectUserRepository = null;
        private readonly IProjectUserFactory _projectUserFactory = null;
        public UserService(IUserRepository userRepository,
            IAccountRepository accountRepository,
            IUserFactory userFactory,
            IAccountFactory accountFactory,
            IJwtProvider jwtProvider,
            IProjectRepository projectRepository,
            IGroupRepository groupRepository,
            IProjectUserRepository projectUserRepository,
            IProjectUserFactory projectUserFactory)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _userFactory = userFactory;
            _accountFactory = accountFactory;
            _jwtProvider = jwtProvider;
            _projectRepository = projectRepository;
            _groupRepository = groupRepository;
            _projectUserRepository = projectUserRepository;
            _projectUserFactory = projectUserFactory;
        }
        public async System.Threading.Tasks.Task<JsonWebToken> Login(string login,string password)
        {
            var dbAccount = await _accountRepository.FindAsync(login,password);
            if(dbAccount==null)
                throw new LoginPasswordException("Bad login or password");
            var dbUser = dbAccount.User;
            var token=_jwtProvider.CreateToken(dbUser.UserId, dbUser.UserType);
            return token;
        }

        public System.Threading.Tasks.Task LogoutAsync()
        {
            
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task RegisterAsync(RegisterUserDto registerUserDto)
        {
            var newAccount = await _accountFactory.CreateAsync(registerUserDto.Email);
            var newUser=await _userFactory.CreateAsync(registerUserDto.Name,registerUserDto.LastName,registerUserDto.UserType,newAccount);
            var dbGroup=await _groupRepository.FindByName(registerUserDto.GroupName);
            var projects = await _projectRepository.FindProjectsByNames(registerUserDto.Projects);
            dbGroup.Users.Add(newUser);
            foreach (var project in projects)
            {
                var newProjectUser = await _projectUserFactory.CreateAsync(project,newUser);
                project.ProjectUsers.Add(newProjectUser);
                newUser.ProjectUsers.Add(newProjectUser);
                await _projectUserRepository.AddAsync(newProjectUser);
            }
            await _userRepository.AddAsync(newUser);
            await _accountRepository.AddAsync(newAccount);
        }

        public async Task<IEnumerable<Core.Domain.User.User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
    }
}
