using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Command;

namespace Services.Report.Command
{
    public class CreateReport:ICommand
    {
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
