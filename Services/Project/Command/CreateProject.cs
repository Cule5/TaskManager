using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Project.Command
{
    public class CreateProject:ICommand
    {
        public string ProjectName { get; set; }
    }
}
