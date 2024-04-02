using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8
{

    class A                                     // base class
    {
        public int x;                           // base class public variable 
        public A()                              // base class defualt constructor
        {

        }


        public A(int x)                        // base class one argument constructor
        {
            this.x = x;
            Console.WriteLine("Class A constructor call using base keyword");
        }


        public int a;
        public int b;
        public A(int a, int b)              // derive class constructor pass the argument in base class constructor 
        {
            this.a = a;
            this.b = b;
        }



        public void Show()                        // base class show method
        {
            Console.WriteLine("Class A method show x=" + x);
        }

        public void Display()                    // base class Display method call from the derive class ki Show4 method se. not create object and call the Display method
        {
            Console.WriteLine("This method call from the derive class");
        }
          
    }



    class B : A                                 // inherit class A                  class A - base class       class B - derive claas
    {
        public int y;                           // derive class variable
        public B()                              // derive class default constructor
        {

        }

        public B(int y)                        // derive class one argument parameter
        {
            this.y = y;
        }

        public void Show2()                    // derive class show2 method call from the derive class object ==> b2.Show2()
        {
            Console.WriteLine("Class B method Show2 y=" + y);
        }




        public int a;
        public int b;
        public B(int c,int d, int a, int b):base(c,d)               // using base keyword pass the argument in base class constructor
        {
            this.a = a;
            this.b = b;
        }

        public void Show3()                                           
        {
            Console.WriteLine("Class B method show3 a=" + a + " b=" + b);
        }


        public void Show4()                                    // class b Show4 method call from the derive class object==> b2.Show4() and 
        {
            Console.WriteLine("This method call from the derive class object and " +
                "also call the base class Display method using base keyword");
            base.Display();                                     // also call the base class method Display

            Console.WriteLine("\n call the base class variable using base keyword : "+base.x);     // call the base class varible using base keyword


        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();         
            B b1 = new B(10);     // Class B object 
            b1.Show2();            // Show2 method


            B b2 = new B(10, 20, 30, 40);  // class B object first two argument are base class constructor and next two aregumet are derive class constructor 
            b2.Show3();         // call the show3 method
            b2.Show();         

            b2.Show4();          // call the derive class method to base class method



            Console.Read();

        }
    }
}
