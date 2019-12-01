using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Command;
using Services.Group.Dtos;
using Services.Project.Dtos;

namespace Services.User.Command
{
    public class EditUser:ICommand
    {
        public int UserId { get; set; }
        public EUserType UserType { get; set; }
        public CommonGroupDto Group { get; set; }
        public IEnumerable<CommonProjectDto> Projects { get; set; }
    }
}
