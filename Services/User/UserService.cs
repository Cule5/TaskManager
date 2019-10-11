using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;

namespace Services.User
{
    public class UserService:IUserService
    {
        private readonly IJwtHandler _jwtHandler = null;
        public UserService(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }
        public System.Threading.Tasks.Task Login(string login,string password)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Logout()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Register()
        {
            throw new NotImplementedException();
        }
    }
}
