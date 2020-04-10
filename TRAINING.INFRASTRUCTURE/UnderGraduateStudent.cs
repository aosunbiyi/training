#define  DEBUG

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
       // UnderGraduateStudent a = "fff";

        public static implicit operator UnderGraduateStudent(string regnum)
        {
            UnderGraduateStudent st = new UnderGraduateStudent("");
            st.RegNum = regnum;
#if DEBUG



            st.Name = "Default";
            st.Phone = "000-000-00";
#endif


            return st;

            // return new UnderGraduateStudent(regnum);
        }

    }
}




