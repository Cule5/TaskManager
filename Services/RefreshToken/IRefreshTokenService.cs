using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Authentication;

namespace Services.RefreshToken
{
    public interface IRefreshTokenService
    {
        Task<JsonWebToken> CreateTokenAsync(string token);
    }
}
