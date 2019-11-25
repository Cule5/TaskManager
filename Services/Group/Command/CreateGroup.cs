using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;
using Services.User.Dtos;

namespace Services.Group.Command
{
    public class CreateGroup:ICommand
    {
        public string GroupName { get; set; }
        public IEnumerable<CommonUserDto> Users { get; set; }
    }
}
