using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    public interface IUserService
    {
        System.Threading.Tasks.Task Login(string login,string password);
        System.Threading.Tasks.Task Logout();
        System.Threading.Tasks.Task Register();
    }
}
