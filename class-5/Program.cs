using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_5
{

    class A
    {
        // const keyword
        //public const int a;   // give error
        public const int a = 5;     // const value cheack at compile time 
        public A()
        {

        }

        public void Show(int x)
        {
            Console.WriteLine("Const keyword");
            x = x + a;
            Console.WriteLine(x);
        }



        // readonly keyowrd
        public readonly int b;            // readonly value cheack at run time
        public readonly int c = 5;
        public static readonly int d = 5;

        public A(int a)
        {
            Console.WriteLine("\nreadonly keyword");
            b = a;
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
        }





        // simple get and set method     //data hiding
        private int x = 12;
        public int get()
        {
            Console.WriteLine("\nget method called");
            x = x + 10;
            return x;
        }

        public void set(int b)
        {
            Console.WriteLine("set method called");
            b = x;
            Console.WriteLine(" b = " + b);
        }



        //  property         //also called accessor methods
        private int y = 12;

        public int Display                     // property method ko overloading nahi kar sakte because parmeter nai hai
        {                                      // but overriding kar sakte hai
            get { y = y + 10; return y; }
            set { y = value; }
        }




        // static property
        private static int z = 12;

        public static int Display2
        {
            get { z = z + 10; return z; }
            set { z = value; }
        }



        // Auto-implemented property
        public int Display3        // in auto-implemented property variable are automatically initialize
        {                           
            get;
            set;
        }


        // read only get method
        String s = "Ruchir";
        public String Display4
        {
            get {  return s ; }
        }


        // write only set method
        public String Display5
        {
            set { s = value; }
        }


        // initialize property
        public int p { get; set; }
        public float q { get; set; }
        public string str { get; set; }







    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            // const keyword method
            a.Show(10);


            //readonly keyowrd object
            A a1 = new A(10);



            // simple get and set method
            Console.WriteLine(a.get());
            a.set(12);


            // property method call
            Console.WriteLine("\nproperty method call");
            Console.WriteLine(a.Display);
            a.Display = 12;



            // static property method call
            Console.WriteLine("\n static property method call");
            Console.WriteLine(A.Display2);
            A.Display2 = 12;


            // Auto-implemented property
            Console.WriteLine("\n Auto-implemented property");
            Console.WriteLine(a.Display3);


            // read only
            Console.WriteLine("\n read only get method");
            Console.WriteLine(a.Display4);


            // write only
            Console.WriteLine("\n write only set method");
            a.Display5 = "Parmar";
            //Console.WriteLine(a.Display5);          // not write because not get method in display5 prperty



            // object initializer
            A a2 = new A()
            {
                p = 12,
                q = 2.3f,
                str = "Ruchir"
            };

            Console.WriteLine("\n Object initializer");
            Console.WriteLine("a2.p = " + a2.p);
            Console.WriteLine("a2.q = " + a2.q);
            Console.WriteLine("a2.str  = " + a2.str);



            Console.Read();


        }
    }
}
