using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_9_3
{
    // partial class program       // write partial keyword to write class any method or memebr anywere in code 
    public partial class A
    {
        public int x;
        public int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine(" x = "+x);
        }
    }

    public partial class  A
    {
        public void Display()
        {
            Console.WriteLine(" y = "+y);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A(10,20);
            a1.Show();
            a1.Display();

            Console.Read();

        }
    }
}
