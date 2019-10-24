using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Group
{
    public interface IGroupService
    {
        System.Threading.Tasks.Task CreateGroup();
        System.Threading.Tasks.Task DeleteGroup();

    }
}
