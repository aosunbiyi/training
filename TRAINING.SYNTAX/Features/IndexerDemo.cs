using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.SYNTAX.Features
{
    public class IndexerDemo
    {
        int[]  numbers = { 4,5,6,7,8,9};

        public int this[int index]
        {
            get { return numbers[index]; }

            set { numbers[index] = value; }
        }
    }
}
