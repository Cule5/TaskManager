using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.RefreshToken.Command
{
    public class RefreshToken:ICommand
    {
        public string Token { get; set; }
    }
}
