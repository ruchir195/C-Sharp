using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_11_1
{

    interface A
    {
        void F1();
    }

    interface B
    {
        void F2();
    }


    class C : A, B
    {
        public void F1()
        {
            Console.WriteLine("F1 method in A interface");
        }

        public void F2()
        {
            Console.WriteLine("F2 method in B interface");
        }
    }


    interface D
    {
     
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            C c1 = new C();
            c1.F1();
            c1.F2();


            A a1 = new C();
            a1.F1();


            B b1 = new C();
            b1.F2();



            Console.Read();
        }
    }
}
