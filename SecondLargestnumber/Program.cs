using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondLargestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 8, 7, 6, 9, 2, 4, 1, 3, 10 };

            int largest = int.MinValue;
            int second = int.MinValue;

            int smallest = int.MaxValue;
            int secondMinNum = int.MinValue;


            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;

                if (i > smallest && i<largest)
                {
                    //secondMinNum = smallest;
                    smallest = i;
                }
                //else if (i < smallest)
                //{
                //    secondMinNum = i;
                //}
            }

            System.Console.WriteLine("\nSecond Largest number : - " + second);

            System.Console.WriteLine("\nSecond Small number : - " + secondMinNum);


            // ---------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n----------------------------------------\n\n");

            var val = new int[] {
         5,
         8,
         7,
         6,
         9,
         2
         ,4
         ,1
             ,3,
                 10
      };

            var maxNum = val.Max(z => z);
            Console.WriteLine("\nMaximum Number: " + maxNum);

            var minNum = val.Min(z => z);
            Console.WriteLine("\nMinimum Number: " + minNum);

            var secondMax = val.OrderByDescending(z => z).Skip(1).First();
            Console.WriteLine("\nSecond Largest Number: " + secondMax);

            var secondMin = val.OrderBy(z => z).Skip(1).First();
            Console.WriteLine("\nSecond Smallest Number: " + secondMin);

            // ---------------------------------------------------------------------------------------------------------------
            // ---------------------------------------------------------------------------------------------------------------














            Console.ReadLine();
        }
    }
}
