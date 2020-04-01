using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.SYNTAX
{
    public  class Nullability
    {
        int? age = null;
        public void Run()
        {
            if (age.HasValue)
            {
                WriteLine($"The value is {age}");
            }
            else
            {
                WriteLine("Empty Value");
            }

            //if (!age.HasValue) age = 5;

            //Null-Coalescing Operator
            age = age ?? 5;

            WriteLine(age);

            String name = null;
            //Null-Conditional Operator
            int? length = name?.Length;

            //Null-Coalescing Operator  &&  Null-Conditional Operator

            int len = name?.Length ?? 0;

            WriteLine(length);

            var val = new { name = "ben", age = 90 };
            WriteLine(val.name + "" + val.age);



        }
    }
}
