using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Group.Exceptions;
using Core.Domain.Group.Repositories;

namespace Core.Domain.Group.Factories
{
    public class GroupFactory:IGroupFactory
    {
        private readonly IGroupRepository _groupRepository = null;
        public GroupFactory(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<Group> CreateAsync(string groupName)
        {
            var dbGroup=await _groupRepository.FindAsync(groupName);
            if(dbGroup!=null)
                throw new GroupException("Group with name like this already exists");
            return new Group(groupName);
        }
    }
}
