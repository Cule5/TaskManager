using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Authentication
{
    public class JsonWebToken
    {
        public string AccessToken { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
    }
}
