using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Identity.Services.PasswordGenerator
{
    public interface IPasswordGenerator
    {
        string Generate(int length);
    }
}
