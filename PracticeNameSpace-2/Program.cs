using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using D;
namespace PracticeNameSpace_2
{
    public class A
    {
        public void Ashow()
        {
            Console.WriteLine("\n PracticeNameSpace_2 and Class A Method Ashow()");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Ashow();

            D.Prac p1 = new D.Prac();
            p1.AccShow();

            p1.v1 = 20;
            //p1.v2                    // give error because v2 is  private variable
            //p1.v3                    // give error bacause v3 is protected variable
            p1.v4 = 50;

            Console.Read();
        }
    }
}




namespace D
{
    public class Prac
    {
        public int v1 = 10;
        private int v2 = 20;
        protected int v3 = 30;
        internal int v4 = 40;


        public void AccShow()
        {
            Console.WriteLine("\n namspace D   class Prac   method AccShow()");
            Console.WriteLine("\n v1 = " + v1 + " v2 = " + v2 + " v3 = " + v3 + "  v4 = "+v4);
        }
    }



    public class Prac2 : Prac
    { 
        public void Prac2Show()
        {
            Console.WriteLine("\n namespace D class prac2 is derive class and ethod prac2Show()");
            Console.WriteLine("\n v1 = " + v1 + "  v2 = "  + " v3 = " + v3 + " v4 = " + v4); // v2 is not accessible because v2 is private 
        }
    }
}
