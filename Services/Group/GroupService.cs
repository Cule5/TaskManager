using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Group.Factories;
using Core.Domain.Group.Repositories;
using Infrastructure.UnitOfWork;

namespace Services.Group
{
    public class GroupService:IGroupService
    {
        private readonly IGroupRepository _groupRepository = null;
        private readonly IGroupFactory _groupFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public GroupService(IGroupRepository groupRepository,IGroupFactory groupFactory,IUnitOfWork unitOfWork)
        {
            _groupRepository = groupRepository;
            _groupFactory = groupFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateGroup(string groupName)
        {
            var newGroup=await _groupFactory.CreateAsync(groupName);
            await _groupRepository.AddAsync(newGroup);
            await _unitOfWork.SaveAsync();
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
