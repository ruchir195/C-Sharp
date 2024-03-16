using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{

    enum department {
        CSE,
        CH,
        CS,
        EC,
        EE,
        ME
     }
    internal class Program
    {
        static void Main(string[] args)
        {

            // datataype

            //value type 
            Console.WriteLine("datatypes\n");
            int a = 23;
            Console.WriteLine("a = "+a);

            double b = 2.33d;
            Console.WriteLine("b = "+b);

            char c = 'a';
            Console.WriteLine("c = "+c);

            bool d = true;
            Console.WriteLine("d = "+d);

            //refernce type
            String str = "Hello Ruchir";
            Console.WriteLine("String = "+str);

            Object obj = new Object();
            Console.WriteLine(obj);




            //type casting
            Console.WriteLine("\ntype casting\n");
            double d1 = 2.33324413d;
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d1 = " + (int)d1);


            int a1 = 4;
            Console.WriteLine("a1 tyep = " + a1.GetType());
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine("a1 = " + Convert.ToString(a1));
            Console.WriteLine("a1 tyep = " + Convert.ToString(a1).GetType());



            // boxing and unboxing
            Console.WriteLine("\nBoxing and unboxing\n");

            //boxing            value -> reference
            int a2 = 5;
            Object obj2 = a2;
            Console.WriteLine("obj2 = "+obj2);
            Console.WriteLine("obj2 type = " + obj2.GetType());

            //unboxing          reference -> value
            int a3 = (int)obj2;
            Console.WriteLine("a3 = " + a3);
            Console.WriteLine("a3 type = " + a3.GetType());



            // var and dynamic

            Console.WriteLine("\nvar and dynamic\n");
            // var type check in compile time
            //var a4;   give error  
            var a4 = 5;
            Console.WriteLine("a4 = " + a4);

            //a4 = "23";  give error beacause not change type    


            // dynamic type check in run time
            dynamic v5;
            v5 = 21;
            Console.WriteLine("v5 = "+ v5);

            v5 = "Ruchir";                  // change the type
            Console.WriteLine("v5 = "+ v5);



            //enum

            Console.WriteLine("\nenum\n");
            department d2 = department.CH;
            Console.WriteLine("d2 = " + d2);

            int i = (int)department.EE;
            Console.WriteLine("i = " + i);

            
            Console.Read();
        }
    }
}
