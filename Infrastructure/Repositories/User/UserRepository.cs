using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.User.Repositories;
using Infrastructure.EntityFramework;

namespace Infrastructure.Repositories.User
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _dbContext = null;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        } 
        public Task AddAsync(Core.Domain.User.User user)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Domain.User.User> FindAsync(Core.Domain.User.User user)
        {
            throw new NotImplementedException();
        }
    }
}
