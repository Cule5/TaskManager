using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Project.Command
{
    public class CreateProject:ICommand
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime StartDate { get; set; }
    }
}
