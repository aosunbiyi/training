using System;
using static System.Console;
using TRAINING.INFRASTRUCTURE;
using TRAINING.SYNTAX;
using static TRAINING.SYNTAX.ClassObject.Console;
using System.Collections.Generic;
using TRAINING.INFRASTRUCTURE.Interface;
using AUDIO = TRAINING.INFRASTRUCTURE.Library.Audio.Converters;
using  VIDEO= TRAINING.INFRASTRUCTURE.Library.Vidoes.Converters;
using TRAINING.INFRASTRUCTURE.Enums;
using TRAINING.INFRASTRUCTURE.OperatorOverloading;

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
            //new Sample1().Run();
            Coach c1 = new Coach();
            c1.Length = 100;
            c1.Breath = 400;
            Coach c2 = new Coach();
            c2.Breath = 200;
            c2.Length = 23;
            Coach c3 = Coach.Add(c1,c2);
            WriteLine(c3.Area);
            Coach c4 = new Coach();
            c4.Breath = 700;
            c4.Length = 400;
            WriteLine(Coach.Add(c3,c4).Area);

            Coach c5 = c3 + c4;
            WriteLine(c5.Area);




            



        }
    }
}