using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Report
{
    public class Report
    {
        public Guid ReportId { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
