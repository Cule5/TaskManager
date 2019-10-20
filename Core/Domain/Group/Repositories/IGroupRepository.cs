using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Group.Repositories
{
    public interface IGroupRepository
    {
        Task<Group> GetAsync(int groupId);
        System.Threading.Tasks.Task AddAsync(Group group);
        Task<Group> FindAsync(Group group);
    }
}
