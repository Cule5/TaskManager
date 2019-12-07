using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.RefreshToken.Repositories
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetAsync(string token);
        System.Threading.Tasks.Task AddAsync(RefreshToken refreshToken);
    }
}
