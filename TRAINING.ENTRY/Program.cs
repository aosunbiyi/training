using System;
using static System.Console;
using TRAINING.INFRASTRUCTURE;
using TRAINING.SYNTAX;
using static TRAINING.SYNTAX.ClassObject.Console;
using System.Collections.Generic;
using TRAINING.INFRASTRUCTURE.Interface;

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
            List<IDiscipline> list = new List<IDiscipline>();
            IDiscipline d1 = new Security("Good behavour");
            IDiscipline d2 = new UnderGraduateStudent("Lovely Security");
            list.Add(d1);
            list.Add(d2);

            foreach (var item in list)
            {
                item.Report();

                if(item is Student st)
                {
                    st.CheckResult();
                }
            }



        }
    }
}