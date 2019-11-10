using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Core.Domain.User.Factories
{
    public interface IUserFactory
    {
        System.Threading.Tasks.Task<User> CreateAsync(string name,string lastName,EUserType userType);
    }
}
