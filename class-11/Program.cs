using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_11
{

    abstract class A
    {
        public int a, b;

        public A()
        {

        }

        // abstract class constructor
        public A(int a, int b) {
            this.a = a;
            this.b = b;
        }
        public abstract void Show();

        // normal property in abstract class;
        public int x = 10;
        public int Prop
        {
            get {x = x + 12 ; return x; }
            set { x = value; }
        }


        // abstract Property
        public abstract int Prop2
        {
            get;
            set;
        }
        

        // normal method
        public void Display()
        {
            Console.WriteLine("Normal method call in abstract class");
        }


        // normal static method
        public static void Display2()
        {
            Console.WriteLine("This is static method");
        }
   
    }



    // class B inherit the class A
    class B : A
    {

        int c, d;

        public B()
        {

        }

        // constructor in B class pass the argument a and b
        // using this constructor call the abstract class constructor
        public B(int a, int b, int c, int d):base(a,b)
        {
            this.c = c;
            this.d = d;
        }

        // abstract class method override
        public override void Show()
        {
            Console.WriteLine("Show method in B class");
        }

 
        // abstract class property override
        public override int Prop2
        {
            get 
            { 
                return 0; 
            }
            set
            {
               
            }
        }


        // this method show the constructor pass the argument value abstract class as well as derive class 
        public void ConsMethod()
        {
            Console.WriteLine(" c = " + c + " d = " + d+ " a = "+base.a+" b = "+base.b);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the derive class refernce and assign derive class object
            Console.WriteLine("\n create the derive class refernce and assign derive class object");
            B b1 = new B();
            b1.Show();


            // create the abstract class reference and assign the derive class object
            Console.WriteLine("\n create the abstract class reference and assign the derive class object");
            A a1 = new B();
            a1.Show();
            a1.Display();


            // normal property call in abstract class
            Console.WriteLine("\n normal property call in abstract class");
            Console.WriteLine(a1.Prop);
            a1.Prop = 20;
            Console.WriteLine(a1.Prop);



            // abstract property call in abstract class
            Console.WriteLine("\n normal property call in abstract class");
            Console.WriteLine(a1.Prop2);
            a1.Prop2 = 30;
            Console.WriteLine(a1.Prop2);



            // abstract class constructor call
            Console.WriteLine("\n abstract class object");
            B b2 = new B(10, 20, 30, 40);     //constructor argument
            b2.ConsMethod();


            // static method call from the abstract class
            A.Display2();

            
            


            Console.Read();
        }
    }
}
