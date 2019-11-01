using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;

namespace Infrastructure.Authentication
{
    public interface IJwtProvider
    {

        JsonWebToken CreateToken(int userId,EUserType userType);
    }
}
