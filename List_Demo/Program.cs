using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             List<>
             * 
             * The List C# data structure was introduced in the .NET Framework 2.0 as part of the new set of generic collections. 
             * List is the generic version of ArrayList, which means that it behaves exactly the same way, but within a specified type. So for example, a List of integers would work as follows:
             * 
             */

            List<int> myList_Int = new List<int>();

            myList_Int.Add(11);
            myList_Int.Add(22);
            myList_Int.Add(33);
            myList_Int.Add(44);
            myList_Int.Add(55);

            foreach (var item_int in myList_Int)
            {
                Console.WriteLine(item_int);
            }

            Console.WriteLine("\n");

            List<string> myList_String = new List<string>();

            myList_String.Add("Test 1");
            myList_String.Add("Test 22");

            //Console.Read();

            foreach (var item in myList_String)
            {
                Console.WriteLine(item);
            }

            //string AA = Console.ReadLine();

            //Console.WriteLine("\n\nArray Value Retrived :- " + myList_String[Convert.ToInt32(AA)]);

            //Console.WriteLine("\n\nEnter Value is : " + AA);

            Console.ReadLine();
        }
    }
}
