using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.User
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
    }
}
