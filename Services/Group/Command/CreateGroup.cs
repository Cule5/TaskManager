using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Group.Command
{
    public class CreateGroup:ICommand
    {
        public string GroupName { get; set; }
    }
}
