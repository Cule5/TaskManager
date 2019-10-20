using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;

namespace Infrastructure.Authentication
{
    public class TokenManager:ITokenManager
    {
        private readonly IDistributedCache _distributedCache = null;
        private readonly IHttpContextAccessor _httpContextAccessor = null;
        private readonly IOptions<JwtSettings> _options = null;
        public TokenManager(IDistributedCache distributedCache,IHttpContextAccessor httpContextAccessor,IOptions<JwtSettings>options)
        {
            _distributedCache = distributedCache;
            _httpContextAccessor = httpContextAccessor;
            _options = options;
        }
        public async Task<bool> IsCurrentActivateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task DeactivateCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsActiveAsync(string token)
        {
            throw new NotImplementedException();
        }

        public async Task DeactivateAsync(string token)
        {
            throw new NotImplementedException();
        }
    }
}
