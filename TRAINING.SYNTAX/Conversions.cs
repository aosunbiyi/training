using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.SYNTAX
{
    public  class Conversions
    {

        class Utility
        {
            int index;
           
            public Utility(int val)
            {
                this.index = val;
            }
        }

        decimal x = 10M;

        public Conversions()
        {
            MyNum n1 = (MyNum)99;
            Console.WriteLine(n1.name +", value "+ n1.val);

            MyNum n2 = new  MyNum(99);
            Console.WriteLine((string)n2);
        }

         class MyNum
        {
           public int val;
           public string name;
            public MyNum(int i) { val = i; }
            public MyNum(string n) { name = n; }

            public static implicit operator MyNum(int a)
            {
                MyNum v = new MyNum(a);
                v.name = "Not Asigned";
                return v;
            }

            public static implicit operator MyNum(string a)
            {
                MyNum v = new MyNum(a);
                v.val = 0;
                return v;
            }

            public static explicit operator int(MyNum n)
            {
                return n.val;
            }

            public static explicit operator string(MyNum n)
            {
                return n.name;
            }

        }

      

       


        // 5.7, 8.900
        class DecimalA
        {
            int _FirstDigit;
            int _LastDigit;

            public DecimalA(int val1 = 0,int val2 =0)
            {
                this._FirstDigit =val1;
                this._LastDigit = val2;
            }

            public decimal Value
            {
                get
                {
                    return Decimal.Parse($"{_FirstDigit}.{_LastDigit}");
                }
            }

            public int FirstDigit
            {
                get { return _FirstDigit; }

                set
                {
                    _FirstDigit = value;
                }
            }
        }
        
      
    }
}
