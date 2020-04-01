using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.SYNTAX
{
   public  class StringFormat
    {

        public void Run()
        {
            SimpleFormat();
        }

        private void SimpleFormat()
        {
            var salary = 15_000_000M;
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(59);
            list.Add(787778);

            WriteLine($"{salary:c}");
            WriteLine($"{DateTime.Now:d}");

            foreach (var data in list)
            {
                Write($"{data,-10:d4}");
            }

        }
    }
}
