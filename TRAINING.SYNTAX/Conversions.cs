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
            MyNum n1 = (MyNum)"Number one";
            Console.WriteLine(n1.name);
        }

         class MyNum
        {
           public int val;
           public string name;
            public MyNum(int i) { val = i; }
            public MyNum(string n) { name = n; }

            public static implicit operator MyNum(int a)
            {
                return new MyNum(a);
            }

            public static implicit operator MyNum(string a)
            {
                return new MyNum(a);
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
