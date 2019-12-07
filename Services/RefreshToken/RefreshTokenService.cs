using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.RefreshToken.Repositories;
using Infrastructure.Authentication;

namespace Services.RefreshToken
{
    public class RefreshTokenService:IRefreshTokenService
    {
        private readonly IRefreshTokenRepository _refreshTokenRepository = null;
        private readonly IJwtProvider _jwtProvider = null;
        public RefreshTokenService(IRefreshTokenRepository refreshTokenRepository,IJwtProvider jwtProvider)
        {
            _refreshTokenRepository = refreshTokenRepository;
            _jwtProvider = jwtProvider;
        }

        public Task<JsonWebToken> CreateTokenAsync(string token)
        {
            throw new NotImplementedException();
        }
    }
}
