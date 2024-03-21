using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{

    class A
    {
        int a, b;

        public A()
        {

        }

        public void Show(int a)
        {
            Console.WriteLine("a = " + a);
        }

        public static void Show2(int a)
        {
            Console.WriteLine("a = " + a);
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Show(12);

            A.Show2(23);

            Console.Read();
        }
    }
}
