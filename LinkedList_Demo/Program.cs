using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist 
            // Using LinkedList class 
            LinkedList<String> my_List = new LinkedList<String>();

            // Adding elements in the LinkedList 
            // Using AddLast() method 
            my_List.AddLast("Zoya");
            my_List.AddLast("Shilpa");
            my_List.AddLast("Rohit");
            my_List.AddLast("Rohan");
            my_List.AddLast("Juhi");
            my_List.AddLast("Zoya");

            //my_List.AddAfter(newRec, "Jagadish");

            Console.WriteLine("Best students of XYZ university:");

            // Accessing the elements of  
            // LinkedList Using foreach loop 
            foreach (string str in my_List)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n\n------------------------------------------------------\nAdding Jagadish after Rohan\n------------------------------------------------------\n");

            var newRec = my_List.AddLast("Rohan");


            Console.ReadLine();
        }
    }
}
