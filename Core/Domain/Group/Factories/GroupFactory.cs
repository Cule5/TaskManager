using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Exceptions;
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
            var dbGroup=await _groupRepository.FindByName(groupName);
            if(dbGroup!=null)
                throw new GroupNameException("Group with given name already exist");
            return new Group(groupName);
        }
    }
}
