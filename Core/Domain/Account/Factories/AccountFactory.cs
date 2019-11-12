using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Account.Repositories;
using Core.Domain.Account.Services.PasswordGenerator;
using Core.Domain.Exceptions;

namespace Core.Domain.Account.Factories
{
    public class AccountFactory:IAccountFactory
    {
        private readonly IAccountRepository _accountRepository = null;
        private readonly IPasswordGenerator _passwordGenerator;
        public AccountFactory(IAccountRepository accountRepository,IPasswordGenerator passwordGenerator)
        {
            _accountRepository = accountRepository;
            _passwordGenerator = passwordGenerator;
        }
        public async Task<Account> CreateAsync(string email)
        {
            var dbAccount=await _accountRepository.FindByEmailAsync(email);
            if(dbAccount!=null)
                throw new EmailException("Account with given email already exists");
            var password = _passwordGenerator.Generate(8);
            return new Account(email,password);
        }
    }
}
