using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Common;

namespace Core.Domain.Account.Factories
{
    public interface IAccountFactory
    {
        Task<Account> CreateAsync(string email,EUserType userType);
    }
}
