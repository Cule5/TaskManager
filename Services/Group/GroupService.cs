using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Group.Factories;
using Core.Domain.Group.Repositories;
using Core.Domain.User.Repositories;
using Infrastructure.UnitOfWork;
using Services.Group.Dtos;
using Services.User.Dtos;

namespace Services.Group
{
    public class GroupService:IGroupService
    {
        private readonly IGroupRepository _groupRepository = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IGroupFactory _groupFactory = null;
        private readonly IUnitOfWork _unitOfWork = null;
        public GroupService(IGroupRepository groupRepository, IUserRepository userRepository,IGroupFactory groupFactory,IUnitOfWork unitOfWork)
        {
            _groupRepository = groupRepository;
            _userRepository = userRepository;
            _groupFactory = groupFactory;
            _unitOfWork = unitOfWork;
        }
        public async System.Threading.Tasks.Task CreateGroupAsync(CreateGroupDto createGroupDto)
        {
            var newGroup=await _groupFactory.CreateAsync(createGroupDto.GroupName);
            foreach (var user in createGroupDto.Users?? Enumerable.Empty<CommonUserDto>())
            {
                var dbUser = await _userRepository.GetAsync(user.UserId);
                if(dbUser==null)
                    continue;
                if(dbUser.Group != null)
                    continue;
                newGroup.Users.Add(dbUser);
                dbUser.Group = newGroup;
            }
            await _groupRepository.AddAsync(newGroup);
            await _unitOfWork.SaveAsync();
        }

        public async System.Threading.Tasks.Task DeleteGroup(string groupName)
        {
            
        }

        
    }
}
