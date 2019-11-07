using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Account.Services
{
    public interface IPasswordGenerator
    {
        string Generate(int length);
    }
}
