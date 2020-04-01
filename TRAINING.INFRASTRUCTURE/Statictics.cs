using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

namespace TRAINING.INFRASTRUCTURE
{
    public class Statictics
    {
        List<int> data = new List<int>();
        const int MAX = 100;
        const int MAX_ROW = 20;

        public void Run()
        {
            LoadData();
            PrintData("GENERATED DATA");
            Sort();
            PrintData("SORTED DATA");
            CalculateMedia();
            CalculateMean();
            CalculateSD();
            GenerateHistogram();
        }


        #region Initialization

      
        private void LoadData()
        {
            for(int i=0;i< MAX; i++)
            {
                var rand = new System.Random();
                var value = rand.Next(1,10);
                data.Add(value);
            }
        }

        private void PrintData(String label)
        {
            int index = 1;
            WriteLine("=====================================================");
            WriteLine($"\t\t\t{label}\n");
         
            foreach (var da in data)
            {
            
                if (index % MAX_ROW == 0)
                    WriteLine( da);
                else
                    Write(da);

                    index++;
            }
      

            WriteLine("\n=====================================================");
        }

        #endregion

        #region Sorting
        private void Sort()
        {
            var dataList = data.ToArray();
            int temp;
            for(int i=0; i< MAX-1; i++)
            {

                for (int j=i +1; j< MAX; j++ ) {
                
                  if(dataList[i] < dataList[j])
                    {
                        temp = dataList[i];
                        dataList[i] = dataList[j];
                        dataList[j] = temp;
                    }
                }

            }

            data = dataList.Select(a => a).ToList();
        }
        #endregion

        #region Calculate Median
        private void CalculateMedia()
        {
            var media = data[(MAX / 2) + 1];
            WriteLine("===================================");
            WriteLine($"Median is {media}\n");
        }
        #endregion

        #region Calculate Mean
        private void CalculateMean()
        {
            float mean = GetMean();

            WriteLine("===================================");
            WriteLine($"Mean is {mean}\n");

        }

        private float GetMean()
        {
            var total = 0;

            for (int i = 0; i < MAX; i++)
            {
                total += data[i];
            }
            var mean = (float)total / (float)MAX;
            return mean;
        }
        #endregion

        #region Calculate Standard Deviation
        private void CalculateSD()
        {
            float mean = GetMean();
            var sd = 0.0;

            for(int i=0; i< MAX; i++)
            {
                sd += Math.Pow(data[i]- mean, 2);
            }

            var sdd = Math.Sqrt(sd / 10);

            WriteLine("===================================");
            WriteLine($"Standard Deviation is {sdd:#######.##}\n");

        }


        #endregion

        #region Histogram
        private void GenerateHistogram()
        {
            int[] bars = new int[10];
            for (int i=1; i< MAX; i++) {

                bars[data[i]] += data[i]; 
            
            }

            for(int i=1; i< 10; i++)
            {
                Write($"[{i}] ==> [{bars[i]}]   ");
                for (int j = 0; j< bars[i]; j++) {

                    Write("*");
                
                }
                WriteLine();
            }
        }
        #endregion

    }
}
