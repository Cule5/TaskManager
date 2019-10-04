using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.User
{
    public interface IUserService
    {
        Task Login();
        Task Logout();
        Task Register();
    }
}
