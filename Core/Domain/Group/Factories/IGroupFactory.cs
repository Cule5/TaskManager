using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Group.Factories
{
    public interface IGroupFactory
    {
        Task<Group> CreateAsync();
    }
}
