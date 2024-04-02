using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_7
{

    class A
    {
        public A() { }
        public int x;
        public A(int x)
        {
            this.x = x;
        }

        public void DisplayA()
        {
            Console.WriteLine("Class A, DisplayA method: "+x);
        }
    }



    class B
    {
        public B()
        {

        }

        int x;
        public B(int x)
        {
            this.x = x;
        }

        public void DisplayB()
        {
            Console.WriteLine("Class B, DisplayB method: " + x);

        }

        A a2;
        public B(A a2)
        {
            this.a2 = a2;
        }

        public void DisplayC()
        {
            Console.WriteLine("Class B, DisplayC method: " + x);
            Console.WriteLine("Class B, DisplayC method: " + a2.x);
            Console.WriteLine("Class B, DisplayC method: " + a2);
        }
    }



    class C : A
    {
        public C()
        {

        }

        int x;
        public C(int x) : base(30)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine(" show method : " + x);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();


            A a2 = new A(10);
            B b2 = new B(20);

            a2.DisplayA();
            b2.DisplayB();


            A a3 = new A(20);
            B b3 = new B(a3);

            b3.DisplayC();

            C c1 = new C(30);
            c1.show();


            Console.Read();

        }
    }
}
