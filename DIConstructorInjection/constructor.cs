using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConstructorInjection
{
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