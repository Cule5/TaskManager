using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Exceptions;
using Core.Domain.Group.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Group
{
    public class GroupRepository:IGroupRepository
    {
        private readonly AppDbContext _dbContext = null;
        public GroupRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Core.Domain.Group.Group> GetAsync(int groupId)
        {
            return await _dbContext.Groups.FindAsync(groupId);
        }

        public async System.Threading.Tasks.Task AddAsync(Core.Domain.Group.Group group)
        {
            var dbGroup=await FindByName(group.GroupName);
            if(dbGroup!=null)
                throw new GroupNameException("Group like this already exists");
            await _dbContext.Groups.AddAsync(group);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Core.Domain.Group.Group> FindByName(string groupName)
        {
            return await _dbContext.Groups.FirstOrDefaultAsync(g=>g.Equals(new Core.Domain.Group.Group(groupName)));
        }

        public async Task<List<Core.Domain.Group.Group>> AllGroups()
        {
            return await _dbContext.Groups.ToListAsync();
        }
    }
}
