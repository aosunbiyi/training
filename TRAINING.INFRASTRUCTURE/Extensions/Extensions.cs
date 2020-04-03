using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Extensions
{
     public static  class Extensions
    {

        public static int ToInt(this string val)
        {
            return Int32.Parse(val);
        }

        public static decimal ToDecimal(this string val)
        {
            return decimal.Parse(val);
        }
    }
}
