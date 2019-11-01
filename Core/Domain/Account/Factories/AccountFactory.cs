using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Account.Repositories;
using Core.Domain.Exceptions;

namespace Core.Domain.Account.Factories
{
    public class AccountFactory:IAccountFactory
    {
        private readonly IAccountRepository _accountRepository = null;
        public AccountFactory(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<Account> CreateAsync(string login, string password)
        {
            var dbAccount=await _accountRepository.FindByLoginAsync(login);
            if(dbAccount!=null)
                throw new LoginPasswordException("User with given login already exists");
            return new Account(login,password);
        }
    }
}
