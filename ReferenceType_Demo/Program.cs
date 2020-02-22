using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceType_Demo
{
    /*
     
     * When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, 
     * it passes the address of the variable. 
     * If we now change the value of the variable in a method, it will also be reflected in the calling method.
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.StudentName = "Bill";

            Console.WriteLine(stud1.StudentName + "\n\n");

            ChanaeReferenceType(stud1);

            Console.WriteLine(stud1.StudentName); ;

            Console.ReadLine();
        }

        static void ChanaeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
    }

    class Student
    {
        public string StudentName { get; set; }
    }
}
