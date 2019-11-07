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
            var dbAccount = await FindByEmailAsync(account.Email);
            if(dbAccount!=null)
                throw new EmailException("User with given email already exists");
            await _dbContext.AddAsync(account);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Account.Account> FindAsync(string email,string password)
        {
            return await _dbContext.Accounts.FirstOrDefaultAsync(a => a.Email.Equals(email) && a.Password.Equals(password));
        }

        public async Task<Core.Domain.Account.Account> FindByEmailAsync(string email)
        {
            return await _dbContext.Accounts.FirstOrDefaultAsync(a=>a.Email.Equals(email));
        }
    }
}
