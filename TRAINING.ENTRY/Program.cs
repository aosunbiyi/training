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
using TRAINING.INFRASTRUCTURE.Delegates;
using TRAINING.INFRASTRUCTURE.Events;

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
            Demo1 d = new Demo1();
            //d.Run();
            Demo2 d2 = new Demo2();
            d2.Run();

            EventPublisher p = new EventPublisher();

            EventSubscriber1 s1 = new EventSubscriber1();
            EventSubscriber2 s2 = new EventSubscriber2();


            p.Added += s1.AddedEventHandler;
            p.Added += s2.AddedEventHandler;

            p.Add(50);





        }
    }
}