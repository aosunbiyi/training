using System;
using System.Collections.Generic;
using System.Text;
using TRAINING.INFRASTRUCTURE.Interface;
using static System.Console;

namespace TRAINING.ENTRY
{
    public class Security : IDiscipline
    {

        public Security(string report)
        {
            this.ReportDetails = report;
        }
        public string ReportDetails { get; set; }

        public void Report()
        {
            WriteLine(ReportDetails+ " => Security");
        }
    }
}
