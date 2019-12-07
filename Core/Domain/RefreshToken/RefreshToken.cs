using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.RefreshToken
{
    public class RefreshToken
    {
        private int RefreshTokenId { get; set; }
        public virtual User.User User { get;set; }
        public virtual string Token { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime? RevokedAt { get; set; }
        public virtual bool Revoked => RevokedAt.HasValue;
    }
}
