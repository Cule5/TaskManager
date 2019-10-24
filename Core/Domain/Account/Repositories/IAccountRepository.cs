using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Account.Repositories
{
    public interface IAccountRepository
    {
        System.Threading.Tasks.Task AddAsync(Account account);
        Task<Account> FindAsync(string login);
    }
}
