using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Common;
using Services.Common.Command;

namespace Services.WorkItem.Command
{
    public class CreateWorkItem:ICommand
    {
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        public ETaskProgress TaskProgress { get; set; }
        public int TaskId { get; set; }
    }
}
