using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.OperatorOverloading
{
    public class Coach
    {
        public int Length { get; set; }

        public int Breath { get; set; }
        public int Area { get; set; }

        public  int ComputeArea()
        {
            Area = Length * Breath;
            return Area;
        }

        public static Coach Add(Coach c1, Coach c2)
        {
            Coach newCoach = new Coach();
            newCoach.Area = c1.ComputeArea() + c2.ComputeArea();
            return newCoach;
        }

        public static Coach operator +(Coach c1, Coach c2)
        {
            Coach newCoach = new Coach();
            newCoach.Area = c1.ComputeArea() + c2.ComputeArea();
            return newCoach;
        }
    }
}
