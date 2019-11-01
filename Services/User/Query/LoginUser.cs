using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Authentication;
using Services.Common.Query;

namespace Services.User.Query
{
    public class LoginUser:IQuery<JsonWebToken>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
