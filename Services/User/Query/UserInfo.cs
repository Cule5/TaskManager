using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.User.Dtos;

namespace Services.User.Query
{
    public class UserInfo:IQuery<ExtendedUserDto>
    {
        public UserInfo(int userId)
        {
            UserId = userId;
        }
        public int UserId { get;}
    }
}
