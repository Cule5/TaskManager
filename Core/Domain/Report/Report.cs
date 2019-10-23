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
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Report);
        }
        public virtual bool Equals(Report report)
        {
            if (report == null)
                return false;
            if (object.ReferenceEquals(this, report))
                return true;

            return Comment == report.Comment && Math.Abs(Time - report.Time) < 0.001&&ReportDate.Equals(report.ReportDate)&&UserId==report.UserId;
        }

        public override int GetHashCode()
        {
            return ReportId;
        }
    }
}
