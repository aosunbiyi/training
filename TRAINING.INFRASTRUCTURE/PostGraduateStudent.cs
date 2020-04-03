using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.INFRASTRUCTURE
{
     public class PostGraduateStudent : Student
    {

        public PostGraduateStudent() :base()
        {
            WriteLine("PostGraduate Contructor");
            base.GenerateReg();
            
        }
        public void ComputeResult() {

            System.Console.WriteLine("Compute Result Postgraduate Student");
        }

        public  void PayFee() { }

        public new void Register()
        {
            base.Register();
            WriteLine("Register Method from PostGraduate Class");
        }

        public sealed override void CheckResult()
        {
            base.CheckResult();
            WriteLine("CheckResult Method from PostGraduate Class");
        }
    }
}
