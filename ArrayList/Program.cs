using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList
                
             * The C# data structure, ArrayList, is a dynamic array. What that means is an ArrayList can have any amount of objects and of any type. 
             * This data structure was designed to simplify the processes of adding new elements into an array. 
             * Under the hood, an ArrayList is an array whose size is doubled every time it runs out of space. 
             * Doubling the size of the internal array is a very effective strategy that reduces the amount of element-copying in the long run. 
             * We won't get into the proof of that here. The data structure is very simple to use:
             
            */

            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(56);
            myArrayList.Add("String");

            //The downside to the ArrayList data structure is one must cast the retrieved values back into their original type:

            int arrayListValue = (int)myArrayList[0];

            string arrayListValue_String = (string)myArrayList[1];
        }
    }
}
