using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Account.Repositories;
using Core.Domain.Exceptions;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Account
{
    class AccountRepository:IAccountRepository
    {
        private readonly AppDbContext _dbContext = null;
        public AccountRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Account.Account account)
        {
            var dbAccount = await FindAsync(account.Login);
            if(dbAccount!=null)
                throw new LoginException("User with given login already exists");
            await _dbContext.AddAsync(account);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Account.Account> FindAsync(string login)
        {
            return await _dbContext.Accounts.FirstOrDefaultAsync(a=>a.Equals(new Core.Domain.Account.Account(login)));
        }
    }
}
