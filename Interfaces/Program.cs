using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is ODD");

            IFive objFive = new ODDEVEN();
            objFive.ONE();
            objFive.THREE();

            Console.WriteLine("\n\nThis is EVEN");

            IEVEN objEven = new ODDEVEN();

            objEven.TWO();
            objEven.FOUR();

            Console.ReadLine();
        }
    }

    // ******************************************

    interface IOne
    {
        void ONE();
    }
    interface ITwo
    {
        void TWO();
    }
    interface IThree : IOne
    {
        void THREE();
    }
    interface IFour
    {
        void FOUR();
    }
    interface IFive : IThree
    {
        void FIVE();
    }
    interface IEVEN : ITwo, IFour
    {
    }

    class ODDEVEN : IEVEN, IFive
    {
        public void ONE()
        {
            Console.WriteLine("This is ONE..!");
        }
        public void TWO()
        {
            Console.WriteLine("This is TWO..!");
        }
        public void THREE()
        {
            Console.WriteLine("This is THREE..!");
        }
        public void FOUR()
        {
            Console.WriteLine("This is FOUR..!");
        }
        public void FIVE()
        {
            Console.WriteLine("This is FIVE..!");
        }
    }
}
