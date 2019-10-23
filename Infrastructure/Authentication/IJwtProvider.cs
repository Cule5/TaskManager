using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Authentication
{
    public interface IJwtProvider
    {

        JsonWebToken CreateToken(int userId);
    }
}
