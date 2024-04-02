using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_10
{

    class A
    {
        public A() { }

        public void Show()
        {
            Console.WriteLine("\n Class A Show method");
        }
    }

    interface B
    {
        void Show();
    }

    interface D
    {
        void Display();
    }


    class C : B,D
    {
        public void Show()
        {
            Console.WriteLine("\n Show method, interface B  body");
        }

        public void Display()
        {
            Console.WriteLine("\n Display method, interface D body ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.Show();
            c1.Display();

            Console.Read();
        }
    }
}
