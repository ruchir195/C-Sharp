using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_4
{

    class ChainingConstructor
    {

        // chaining constructor 
        // create only one object for default constructor and call both default and parameterized constructor
        public ChainingConstructor(int a)
        {
            Console.WriteLine("\n chaining constructor");
            Console.WriteLine("a = " + a);
        }

        public ChainingConstructor(): this(20)
        {
            Console.WriteLine("default constructor");
        }




        // copy constructor
        //c# doesn't have copy constructor but achieve the same functionality through various methods

        int a, b;
        public ChainingConstructor(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("\nCopy method");
            Console.WriteLine("parameter constructor called with value a = "+a + " b = " + b);
        }

        public ChainingConstructor(ChainingConstructor cc)
        {
            this.a = cc.a;
            this.b = cc.b;
            Console.WriteLine("Copy constructor called with value a = " + cc.a + " b= " + cc.b);
        }




        // C# default argument method
        // c# default argument constructor is also created but problem at run time to ambiges value
        // means usually not created default parameter constructor
        public void Show(int a, int b, int c = 5)
        {
            
            Console.WriteLine("a = " + a + " b = " + b + " c = " + c);
        }




        // static

        // static variable
        int a0 = 30;
        static int a1 = 20;
        static int b1 = 10;

        //static method
        // static method only access static member 
        public static void Display()
        {
            Console.WriteLine("\nStatic method");
            //Console.WriteLine("a0 = " + a0);     // give error
            Console.WriteLine("a1 = " + a1 + " b1 = " + b1);
        }

        public void Display2()
        {
            Console.WriteLine("\nNormal method");
            Console.WriteLine("a0 = " + a0 + " a1 = " + a1 + " b1 = " + b1);
        }



        // static constructor

        static int x1 = 20;
        static int x2;
        static ChainingConstructor()
        {
            x2 = x1 * 5;
            Console.WriteLine("\n static constructor");
            Console.WriteLine("x1 = " + x1 + " x2 = " + x2);
        }




        // private constructor

        private ChainingConstructor(int a, int b, int c)
        {
            Console.WriteLine("\n private constructor are called");
        }


        public static void Show2()
        {
            Console.WriteLine("\n private constructor public static method");
        }







        // Destructor
        ~ChainingConstructor()
        {
            Console.WriteLine("destructor called");
        }
    }



    // static class
    // in static class all the member are static and method are also static 
    public static class ExStaticClass
    {
        //int a; // give error
        static int a = 100;
        public static void Show(int a)
        {
            Console.WriteLine("\n static class");
            Console.WriteLine("a = " + a);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            // chaining constructor object
            ChainingConstructor cc = new ChainingConstructor();


            // copy constructor object
            ChainingConstructor cc2 = new ChainingConstructor(4, 5);
            ChainingConstructor cc3 = new ChainingConstructor(cc2);


            // c# default arguments method
            // cc.Show(10);   // give error
            Console.WriteLine("\nc# default argument method");
            cc.Show(10, 20);
            cc.Show(10, 200, 300);



            // static method
            ChainingConstructor.Display();
            //ChainingConstructor.Display2();    // give error normal method not accessible by class name
            cc.Display2();


            // static constructor;
            ExStaticClass.Show(10);

            // private constructor method call
            ChainingConstructor.Show2();

            Console.Read();
        }
    }
}
