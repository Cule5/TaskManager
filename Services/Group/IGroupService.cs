using System;
using System.Collections.Generic;
using System.Text;
using Services.Group.Dtos;

namespace Services.Group
{
    public interface IGroupService
    {
        System.Threading.Tasks.Task CreateGroupAsync(CreateGroupDto createGroupDto);
        System.Threading.Tasks.Task DeleteGroup(string groupName);

    }
}
