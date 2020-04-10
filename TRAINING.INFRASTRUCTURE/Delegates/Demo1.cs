using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Delegates
{
    public class Demo1
    {
       public delegate void MyDelegate(String name);

        public void Run()
        {
            Test1();
        }

        private void Test1()
        {
            MyDelegate de = new MyDelegate(Register);
            de("James Bonf");
            de+=Print;

            de("090876433");

            MyDelegate d2 = delegate (string name)
            {
                Console.WriteLine("Name " + name);
            };

            d2("");
        }

        public void Print(string name) {
            Console.WriteLine("Name "+name);
        }

        public void Register(string phone)
        {
            Console.WriteLine(phone +" was Registered");
        }
    }
}
