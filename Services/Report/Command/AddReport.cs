using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;

namespace Services.Report.Command
{
    public class AddReport:ICommand
    {
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
