using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Report
{
    public class Report
    {
        public Report(string comment,double time,DateTime reportDate)
        {
            Comment = comment;
            Time = time;
            ReportDate = reportDate;
        }
        public int ReportId { get; set; }
        public string Comment { get; set; }
        public double Time { get; set; }
        public DateTime ReportDate { get; set; }
        public int UserId { get; set; }
        public virtual User.User User { get; set; }
    }
}
