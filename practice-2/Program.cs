using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    // normal class
    class A
    {
        int a;
        int c;

        public A()
        {
           
        }

        public A(int a)
        {
            this.a = a;
        }

        public static int b = 20;

        public void Show(int a)
        {
            Console.WriteLine("\n normal method");
            Console.WriteLine("a = " + a);
            Console.WriteLine("Static variable");
            Console.WriteLine("b = " + b);
        }


        

        public static void Show2(int a)
        {
            Console.WriteLine("\n static method");
            Console.WriteLine(" a = " + a);
            Console.WriteLine("static variable");
            Console.WriteLine(" b = " + b);
           // Console.WriteLine(" c = " + c);            // give error because normal member are not access by static method
        }


        static int x = 20;
        static int y;

        static A()
        {
            Console.WriteLine("\n static constructor called");                                                                                                                                    
            y = x + 10;
            Console.WriteLine("x = " + x + " y = " + y);
        }



        // property
        private int k = 10;
       public int K
        {
            get { k = k + 10; return k; }
            set { k = value; }
        }


        // static property
        private static int m = 10;
        public static int M
        {
            get { m = m * 10; return m; }
            set { m = value; }
        }



        // read only property
        private String str = "Ruchir";
        public String N
        {
            get { return str; }
        }


        // write only property

        private String str2;
        public String O
        {
            set { str2 = value; }
        }

        public int X { get; set; }
        public float Y { get; set; }
        public String Z { get; set; }


        const int p = 10;
        public void Display2()
        {
            Console.WriteLine("\n const keyword");
            Console.WriteLine("p = " + p);
        }


        public readonly int r;
        public readonly int s = 20;
        public static readonly int t = 30;


        public A(int a, int b)
        {
            Console.WriteLine("r = " + r);
            Console.WriteLine("s = " + s);
            Console.WriteLine("t = " + t);
        }

        




        
    }

    // static class 
    static class B
    {
       // int a; // give error 
        static int a;

        static B()
        {
            Console.WriteLine("\n static class constructor");
        }


        public static void Show2(int a)
        {
            Console.WriteLine("a = " + a);
        }
    }




    class C
    {
        public void Show(ref int a, ref int b)
        {
            Console.WriteLine("\n ref keyword");
            Console.WriteLine("a = " +a);
            Console.WriteLine("b = " +b);
        }

        public void Show2(out int a, out int b)
        {
            a = 5;
            b = 10;
            Console.WriteLine("\n out keyword");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A(10);

            // normal method call
            a.Show(20);


            // static method call
            A.Show2(20);

            // static class method call
            B.Show2(30);

            // property
            Console.WriteLine("\n property");
            Console.WriteLine(a.K);
            a.K = 20;


            // static property
            Console.WriteLine("\n static property");
            Console.WriteLine(A.M);
            A.M = 30;

            //read only property
            Console.WriteLine("\n read only property");
            Console.WriteLine(a.N);


            //write only property
            Console.WriteLine("\n write only property");
            a.O = "Parmar";
            Console.WriteLine("\n value set successfully done");


            // object initialize
            Console.WriteLine("\n object initialize");
            A a2 = new A()
            {
                X = 100,
                Y = 12.5f,
                Z = "Ruchir"
            };

            Console.WriteLine(" a2.x = " + a2.X);
            Console.WriteLine(" a2.y = " + a2.Y);
            Console.WriteLine(" a2.z = " + a2.Z);

            a.Display2();


            // readonly keyword
            Console.WriteLine("\nreadonly keyword");
            A a3 = new A(10, 20);



            C c = new C();

            // call by value
            int d = 40;
            int f = 50;
           // c.Show3(int d, int f);

            // call by ref
            int p = 20;
            int q = 30;
            c.Show(ref p, ref q);
            Console.WriteLine("\n in main method");
            Console.WriteLine(" p = " + p);
            Console.WriteLine(" q = " + q);


            // call by out
            int r, s;
            c.Show2(out r, out s);
            Console.WriteLine("\n in main method");
            Console.WriteLine(" r = " + r);
            Console.WriteLine(" s = " + s);


            // var keyword
            Console.WriteLine("\n var keyword");
            var e = 20;
            Console.WriteLine(e);
            e = 12;
            Console.WriteLine(e);

            //e = "ruchir"; // give error


            // dynamic keyword
            Console.WriteLine("\n dynamic keyword");
            dynamic l = 20;
            Console.WriteLine(l);
            l = 30;
            Console.WriteLine(l);
            l = "Ruchir";
            Console.WriteLine(l);







            Console.Read();
        }
    }
}

