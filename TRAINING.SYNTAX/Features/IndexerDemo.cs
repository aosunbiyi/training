using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.SYNTAX.Features
{
    public class IndexerDemo
    {
        int[] numbers = { 4, 5, 6, 7, 8, 9 };
        string[] phones = { "phone1", "phone2", "phone3", "phone4" };

        public int this[int index]
        {
            get {
                if (index > 0 && index < numbers.Length)
                    return numbers[index];
                else
                    return 0;
            }

            set {
                if (index > 0 && index < numbers.Length)
                    numbers[index] = value;

            }
        }

        public string this[int index, int index2]
        {
            get
            {
                if (index > 0 && index < numbers.Length)
                    return phones[index];
                else
                    return null;
            }

            set
            {
                if (index > 0 && index < numbers.Length)
                    phones[index] = value;

            }
        }

        public int  this[string data]
        {
            get
            {

                return Array.IndexOf(phones, data);
                
            }

        }

        
    }
}
