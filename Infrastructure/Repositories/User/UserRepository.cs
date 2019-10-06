﻿using System;
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

        public async Task<Core.Domain.User.User> GetAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.User.User user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.User.User> FindAsync(Core.Domain.User.User user)
        {
            throw new NotImplementedException();
        }
    }
}
