﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.User.Repositories;

namespace Core.Domain.User.Factories
{
    public class UserFactory:IUserFactory
    {
        private readonly IUserRepository _userRepository = null;
        public UserFactory(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async System.Threading.Tasks.Task<User> CreateAsync(string login,string password)
        {
            var dbUser=await _userRepository.FindAsync(login, password);
            return dbUser ?? new User(login,password);
        }
    }
}
