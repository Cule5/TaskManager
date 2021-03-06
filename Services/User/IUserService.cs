﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;
using Services.User.Dtos;

namespace Services.User
{
    public interface IUserService
    {
        System.Threading.Tasks.Task<JsonWebToken> Login(string login,string password);
        System.Threading.Tasks.Task LogoutAsync();
        System.Threading.Tasks.Task RegisterAsync(RegisterUserDto registerUserDto);
        Task<IEnumerable<Core.Domain.User.User>> GetAllUsersAsync();
    }
}
