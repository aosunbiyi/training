using System;
using static System.Console;
using TRAINING.INFRASTRUCTURE;
using TRAINING.SYNTAX;
using static TRAINING.SYNTAX.ClassObject.Console;
using System.Collections.Generic;

namespace TRAINING.ENTRY
{

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ForeignPostGraduateStudent st = new ForeignPostGraduateStudent();
            st.CheckResult();
            

            StudentSimo stSimo = new StudentSimo();
            stSimo.SimoFor1();

            OutSideStudent os = new OutSideStudent();
            WriteLine("From Out Side Student");
            os.ShowReg();
            
           

        }
    }
}
