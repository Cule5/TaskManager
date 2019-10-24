using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.GroupProject.Repositories
{
    public interface IGroupProjectRepository
    {
        System.Threading.Tasks.Task AddAsync(GroupProject groupProject);
    }
}
