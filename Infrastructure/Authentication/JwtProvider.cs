using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Authentication
{
    public class JwtProvider:IJwtProvider
    {
        private readonly JwtSettings _jwtSettings = null;
        public JsonWebToken CreateToken(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
