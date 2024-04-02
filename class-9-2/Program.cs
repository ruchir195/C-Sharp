using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_9_2
{
    // abstract program
    class A
    {
        public A()
        {

        }

        public void Show()
        {
            Console.WriteLine("\n class A Normal method show");
        }
    }

    // abstract class                // abstract class me normal method as well as abstract method ko bana sakte hai
    abstract class B 
    {
        public void Show()                          // normal method
        {
            Console.WriteLine("\n Class B Normal method Show");
        }

        abstract public void Display();             //abstract method
    }                                                // abstract method ko override nahi kar sakte hai because uski body hi nahi hoty

   // class C
   // {
   //     abstract public void Show();  // give error because abstract class me hi abstract method use kar sakte hai
   // }

    class D:B
    {
        public D()
        {

        }

        public override void Display()
        {
            Console.WriteLine("\n abstract class method body wriiten in derive class means B class");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            a1.Show();

            B b1;      // abstract class ka references bana sakte hai

            //B b1 = new B();     /// give error because abstract class ka object nahi bana sakte


            D d1 = new D();
            d1.Display();

            Console.Read();

        }
    }
}
