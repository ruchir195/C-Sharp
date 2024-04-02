using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8_1
{

    class A
    {
        public int x;
        public A()
        {

        }

        public A(int x)
        {
            this.x = x;
        }

        // overhiding method
        public void Show()
        {
            Console.WriteLine("Show method in base class");
        }



        // overriding method
        public virtual void Display()
        {
            Console.WriteLine("\n Display method in base class using virtual keyword");
        }


    }

    class B:A
    {
        public int y;

        public B()
        {

        }

        public B(int y)
        {
            this.y = y;
        }


        // overhiding method
        public void Show()
        {
            Console.WriteLine("Show method in derive class");
        }

        // overriding method
        public override void  Display()
        {
            Console.WriteLine("Display method in derive class using override method");
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();

            A a2 = new A(20);
            B b2 = new B(40);

            a2.Show();    
            b2.Show();



            // overhiding     
            A r = b2;
            r.Show();     // call the base class method

            A r1 = a2;
            r1.Show();    // call the base class method



            // overriding
            A r3 = a2;
            r3.Display();     // call the base class method

            A r4 = b2;
            r4.Display();     // call the derive class method




           // B f = a2;      // give errror because derive class k refernce ko base class ka object nahi de sakte 
            //f.Display(); 


            Console.Read();
        }
    }
}
