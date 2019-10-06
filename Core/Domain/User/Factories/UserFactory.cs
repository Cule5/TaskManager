using System;
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
        public System.Threading.Tasks.Task CreateAsync(string login,string password,string email)
        {
            throw new NotImplementedException();
        }
    }
}
