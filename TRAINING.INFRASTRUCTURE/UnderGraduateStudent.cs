using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using TRAINING.INFRASTRUCTURE.Interface;

namespace TRAINING.INFRASTRUCTURE
{
    public class UnderGraduateStudent : Student, IDiscipline
    {

        public UnderGraduateStudent(string report) {
            this.ReportDetails = report;
        }
        public string ReportDetails { get; set; }

        public void ComputeResult() {

            System.Console.WriteLine("Compute Result Undergraduate Student");
        }


        public void PayFee() { }

        public void Report()
        {
            WriteLine(ReportDetails +" => UnderGraduate");
        }
    }
}
