using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Group.Factories;
using Core.Domain.Group.Repositories;

namespace Services.Group
{
    public class GroupService:IGroupService
    {
        private readonly IGroupRepository _groupRepository = null;
        private readonly IGroupFactory _groupFactory = null;
        public GroupService(IGroupRepository groupRepository,IGroupFactory groupFactory)
        {
            _groupRepository = groupRepository;
            _groupFactory = groupFactory;
        }
        public async System.Threading.Tasks.Task CreateGroup(string groupName)
        {
            var newGroup=await _groupFactory.CreateAsync(groupName);
            await _groupRepository.AddAsync(newGroup);
        }

        public async System.Threading.Tasks.Task DeleteGroup(string groupName)
        {
            
        }

        public async Task<List<string>> AllGroups()
        {
            var groupsList = await _groupRepository.AllGroups();
            var groupNameList=new List<string>();
            foreach (var group in groupsList)
            {
                groupNameList.Add(group.GroupName);
            }
            return groupNameList;
        }
    }
}
