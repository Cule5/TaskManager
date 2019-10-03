using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    interface IUserService
    {
        Task Login();
        Task Logout();
        Task Register();
    }
}
