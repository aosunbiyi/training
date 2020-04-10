using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Delegates
{
    public class Demo2
    {

        List<int> list = new List<int>{ 1, 3, 4, 5, 6, 7 };
        Func<int, int> Expand2 = (int x) => x * x;
        Func<int, int> Expand3 = x => x * x;
        public void Expand(ref int par)
        {
            par = par * 3;
        }

        public void Run()
        {
            foreach (int item in list)
            {
                var holder = Expand2(item);
                //Expand(ref holder);
                Console.WriteLine(holder);
            }
        }



        public Func<string,int> LamdaExpression()
        {
            Func<int,string,int> x = (int x,string a) => x * x; //Expression1 

            Func<string, int> x2 = delegate (string name)
             {
                 return name.Length;
             };

            Console.WriteLine(x(5,"James"));


            return x2;
        }

        public int Expression1(int val1, string val2)
        {
            return val1 * val1;
        }
    }
}
