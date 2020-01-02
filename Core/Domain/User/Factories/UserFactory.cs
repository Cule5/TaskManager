using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Account.Repositories;
using Core.Domain.Common;
using Core.Domain.Exceptions;
using Core.Domain.User.Repositories;

namespace Core.Domain.User.Factories
{
    public class UserFactory:IUserFactory
    {
        private readonly IUserRepository _userRepository = null;
        private readonly IAccountRepository _accountRepository = null;
        public UserFactory(IUserRepository userRepository,IAccountRepository accountRepository)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }

        

        public Task<User> CreateAsync(string name, string lastName)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(() => new User(name, lastName));
        }
    }
}
