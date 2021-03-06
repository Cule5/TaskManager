﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.User.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.User
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _dbContext = null;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Core.Domain.User.User> GetAsync(int userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.User.User user)
        {
            await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.User.User> FindAsync(string name, string lastName)
        {
            return await _dbContext.Users.FirstOrDefaultAsync((u)=>u.Equals(new Core.Domain.User.User(name,lastName)));
        }

        public async Task<IEnumerable<Core.Domain.User.User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
