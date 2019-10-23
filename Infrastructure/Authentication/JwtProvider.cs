using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Authentication
{
    public class JwtProvider:IJwtProvider
    {
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = null;
        private readonly JwtSettings _jwtSettings = null;

        public JwtProvider(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
            _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        }
        public JsonWebToken CreateToken(int userId)
        {
            //var key= Encoding.ASCII.GetBytes(_jwtSettings.SecretKey);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, userId.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(7),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = _jwtSecurityTokenHandler.CreateToken(tokenDescriptor);
            return null;
        }
    }
}
