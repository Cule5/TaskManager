using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.RefreshToken.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.RefreshToken
{
    public class RefreshTokenRepository:IRefreshTokenRepository
    {
        private readonly AppDbContext _dbContext = null;
        public RefreshTokenRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Core.Domain.RefreshToken.RefreshToken> GetAsync(string token)
        {
            return  null;
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.RefreshToken.RefreshToken refreshToken)
        {
            await _dbContext.AddAsync(refreshToken);
        }
    }
}
