using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;


namespace TRAINING.SYNTAX
{

    public  class Strings
    {



        #region String Interpolation Sample

        public void StringInterpolation()
        {
            var name = "James Bond";
            var tax = 0.25;
            var allowance = 12_000M;
            var transportaion = 8_000M;
            var housing = 1_500;

            String story = "Game";
            story = "Game of Thrones";

            StringBuilder movies = new StringBuilder("Die Hard 4");
            movies.Append("Killer Instinct_3");
            movies.Append("Text22");
            movies.Insert(1,"Gim002");

            String movieText = movies.ToString();
            WriteLine(movieText);

            WriteLine($"Employee name {name}\n Deduction = {allowance - (allowance* (decimal)tax) - housing}");
        }


        #endregion

        #region Deduction Computation

        private void ComputeDeductions()
        {
          
        }

        #endregion


        #region Array Manipulations

        public void ListManger()
        {
            int[,] list = new int[2,2];
            list[0, 0] = 5;
            list[0, 1] = 3;
            list[1, 0] = 8;
            list[1, 1] = 9;

        
            for (int row =0; row < 2; row++)
            {
            
                for (int col= 0;col< 2; col++)
                {
                    Write($"{list[row,col]}");
                }
                WriteLine();


            }
        }

        #endregion


    }
}
