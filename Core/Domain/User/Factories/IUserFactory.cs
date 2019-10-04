using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.User.Factories
{
    public interface IUserFactory
    {
        System.Threading.Tasks.Task CreateAsync();
    }
}
