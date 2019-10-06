using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Report.Command
{
    public class AddReport:ICommand
    {
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
