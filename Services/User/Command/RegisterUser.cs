using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Command;
using Services.Project.Dtos;

namespace Services.User.Command
{
    public class RegisterUser:ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EUserType UserType { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<CommonProjectDto> Projects { get; set; }
        
    }
}
