using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.User.Repositories
{
    public interface IUserRepository
    {
        System.Threading.Tasks.Task AddAsync(User user);
        Task<User> FindAsync(User user);
    }
}
