using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList_Demo
{
    //  https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

    //  Go through the abouve link for more details. Briefing below

    //  Linked List is a linear data structure which consists of a group of nodes in a sequence. Each node contains two parts.
    //      Data− Each node of a linked list can store a data.
    //      Address − Each node of a linked list contains an address to the next node, called "Next".

    //  https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/Images/LL_1.png



    //  The first node of a Linked List is referenced by a pointer called Head

    //  A LinkedList is a linear data structure which stores element in the non-contiguous location. 
    //  The elements in a linked list are linked with each other using pointers. 
    //  Or in other words, LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.

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
