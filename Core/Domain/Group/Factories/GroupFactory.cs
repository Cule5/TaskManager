using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Group.Factories
{
    public class GroupFactory:IGroupFactory
    {
        public Task<Group> CreateAsync()
        {
            return System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                return new Group();
            });
        }
    }
}
