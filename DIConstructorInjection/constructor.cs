using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConstructorInjection
{
    //  For more information read below link
    //  https://www.tutorialsteacher.com/ioc

    //  below example is taken for practice from below link
    //  https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/

    //  Dependency Injection(DI) is a software design pattern. It allows us to develop 
    //  loosely-coupled code. The intent of Dependency Injection is to make code maintainable.
    //  Dependency Injection helps to reduce the tight coupling among software components.
    //  Dependency Injection reduces the hard-coded dependencies among your classes by 
    //  injecting those dependencies at run time instead of design time technically.
    //  This article explains how to implement Dependency Injection in C# and .NET code.

    //  ---------------------
    //  Constructor Injection
    //  ---------------------

    //  This is the most commonly used dependency pattern in Object Oriented Programming.
    //  The constructor injection normally has only one parameterized constructor, 
    //  so in this constructor dependency there is no default constructor and we need 
    //  to pass the specified value at the time of object creation. We can use the 
    //  injection component anywhere within the class. It addresses the most common 
    //  scenario where a class requires one or more dependencies.

    public interface text
    {
        void print();
    }
    class format : text
    {
        public void print()
        {
            Console.WriteLine(" here is the text format");
        }
    }

    // constructor injection
    public class ConstructorInjection
    {
        private text _text;

        public ConstructorInjection(text t1)
        {
            this._text = t1;
        }

        public void print()
        {
            _text.print();
        }
    }

    class constructor
    {
        static void Main(string[] args)
        {
            ConstructorInjection ci = new ConstructorInjection(new format());
            ci.print();
            Console.ReadLine();
        }
    }
}