using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.SYNTAX
{
    public class ClassObject
    {
        public static int counter = 0;
        public int instanceCounter = 0;

        public ClassObject()
        {
            ClassObject.counter++;
        }

        public ClassObject(int initValue): this()
        {
            this.instanceCounter = initValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iniValue"></param>
        /// <param name="phone"></param>
        public ClassObject(int iniValue, int phone): this(initValue: iniValue)
        {

        }

        public static void Increment()
        {
            ClassObject.counter++;

        }

        public void Add()
        {
            this.instanceCounter += ClassObject.counter;
        }

        public static class Console{
        
            public static void WriteLine2()
            {

            }
        }

    }
}
