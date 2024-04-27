using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamdaFunction
{

    delegate void p1();
    delegate int p2(int a, int b);
    delegate int p3(int a, int b, int c);
    delegate bool p4(int a, int b);
    delegate String p5(String a, String b);
    

    internal class Program
    { 
        static void Main(string[] args)
        {
            p1 s = () => Console.WriteLine("Hello");
            s();

            p2 s2 = (x, x1) => x * x1;
            Console.WriteLine(s2(10, 20));

            p3 s3 = (x, y, y1) => y + y1 + x;
            Console.WriteLine(s3(20, 20, 10));

            p4 s4 = (x, y) => x > y;
            Console.WriteLine(s4(20, 10));

            p5 s5 = (x, y) => x + y;
            Console.WriteLine(s5("Ruchir", " Parmar"));



             
            
            Console.Read();

        }
    }
}
