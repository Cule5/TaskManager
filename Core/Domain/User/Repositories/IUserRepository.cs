using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.User.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(int userId);
        System.Threading.Tasks.Task AddAsync(User user);
        Task<User> FindAsync(string login,string password);
    }
}
