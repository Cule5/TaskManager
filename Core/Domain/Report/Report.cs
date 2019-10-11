using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Report
{
    public class Report
    {
        public int ReportId { get; set; }
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        public User.User User { get; set; }
    }
}
