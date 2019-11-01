using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core.Domain.Common;
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
        public JsonWebToken CreateToken(int userId,EUserType userType)
        {
            var now = DateTime.UtcNow;
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var time = now.Subtract(new TimeSpan(epoch.Ticks));
            var ticks=time.Ticks / 10000;

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(ClaimTypes.Role, userType.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, ticks.ToString(), ClaimValueTypes.Integer64)
            };

            var expiresTime = now.AddMinutes(_jwtSettings.ExpiryMinutes);
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
                SecurityAlgorithms.HmacSha256);
            var jwt = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                claims: claims,
                notBefore: now,
                expires: expiresTime,
                signingCredentials: signingCredentials
            );
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            
            var epoch1 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var time1 = expiresTime.Subtract(new TimeSpan(epoch1.Ticks));
            var ticks1 = time1.Ticks / 10000;

            return new JsonWebToken()
            {
                Token = token,
                Expires = ticks1
            };
        }
    }
}
