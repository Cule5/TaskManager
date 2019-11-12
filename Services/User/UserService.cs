using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using Core.Domain.Common;
using Core.Domain.Group.Repositories;
using Core.Domain.Project.Repositories;
using Core.Domain.ProjectUser.Factories;
using Core.Domain.ProjectUser.Repositories;
using Infrastructure.Email;
using Infrastructure.UnitOfWork;

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
        private readonly IUnitOfWork _unitOfWork = null;
        private readonly IEmailSender _emailSender = null;
        public UserService(IUserRepository userRepository,
            IAccountRepository accountRepository,
            IUserFactory userFactory,
            IAccountFactory accountFactory,
            IJwtProvider jwtProvider,
            IProjectRepository projectRepository,
            IGroupRepository groupRepository,
            IProjectUserRepository projectUserRepository,
            IProjectUserFactory projectUserFactory,
            IUnitOfWork unitOfWork,
            IEmailSender emailSender)
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
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
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
            var dbGroup = await _groupRepository.FindByName(registerUserDto.GroupName);
            var newUser=await _userFactory.CreateAsync(registerUserDto.Name,registerUserDto.LastName,registerUserDto.UserType);
            newUser.Account = newAccount;
            newUser.Group = dbGroup;
            dbGroup?.Users.Add(newUser);
            foreach (var project in registerUserDto.Projects)
            {
                var dbProject = await _projectRepository.FindByNameAsync(project);
                if (dbProject == null) continue;
                var projectUser = await _projectUserFactory.CreateAsync(dbProject, newUser);
                dbProject.ProjectUsers.Add(projectUser);
                newUser.ProjectUsers.Add(projectUser);
                await _projectUserRepository.AddAsync(projectUser);
            }
            await _accountRepository.AddAsync(newAccount);
            await _userRepository.AddAsync(newUser);
            await _unitOfWork.SaveAsync();
            _emailSender.Send(newAccount.Email,newAccount.Password);
        }
    }
}
