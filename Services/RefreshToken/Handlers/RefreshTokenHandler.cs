using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.RefreshToken.Handlers
{
    public class RefreshTokenHandler:ICommandHandler<Command.RefreshToken>
    {
        private readonly IRefreshTokenService _refreshTokenService = null;
        public RefreshTokenHandler(IRefreshTokenService refreshTokenService)
        {
            _refreshTokenService = refreshTokenService;
        }
        public async System.Threading.Tasks.Task HandleAsync(Command.RefreshToken command)
        {
            await _refreshTokenService.CreateTokenAsync(command.Token);
        }
    }
}
