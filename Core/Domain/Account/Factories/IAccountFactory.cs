using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Account.Factories
{
    public interface IAccountFactory
    {
        Task<Account> CreateAsync(string login,string password);
    }
}
