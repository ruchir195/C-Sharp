using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_9_1
{
    // run time polymorphism program
    class A
    {
        public A() { }

        public virtual void Show()
        {
            Console.WriteLine("\n Class A method Show");
        }
    }

    class B:A
    {
        public B() { }

        public override void Show()
        {
            Console.WriteLine(" Class B method Show");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();


            // run time polymorphism
            A a2 = b1;
            a2.Show();     // derive class method call


            A a3 = new A();     // tight coupling
            A a4 = new B();     // loose coupling

            a3.Show();       // base class method call
            a4.Show();       // derive class method call

            Console.Read();
        }
    }
}
