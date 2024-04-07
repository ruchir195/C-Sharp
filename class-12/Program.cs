using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace class_12
{
    // Struct program

    // struct is value type
    // class is reference type
    struct A
    {
        public int x;

        //public int x = 23;            // give error because struct me value assign nahi kar sakte but class me kar sakte hai 
        

        //public A()                   // give error because struct only access parameterize constructor
        //{

        //}

        // parameterize constructor
        public A(int x)
        {
            this.x = x;
        }

       
        // Method
        public void Show()
        {
            Console.WriteLine("In Struxt Show Method x = " + x);
        }



        //Property
        public int X
        {
            get { x = x + 1; return x; }
            set { x = value; }
        }


        public static int y = 10;

        // static property
        public static int Y
        {
            get { y = y + 10; return y; }
            set { y = value; }
        }


        // static method
        public static void Display()
        {
            Console.WriteLine("This is Static Display method");
        }


        // indexer
        //public int[] b; 
        //public int this[int i]
        //{
        //    get { return b[i]; }
        //    set { b[i] = value; }
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();                            // A a ==> variable          // new A ==> Constructor

            A a1 = new A(10);                         // A a ==> varibale           // new A(10) ==> argument constructor
            a1.Show();

            Console.WriteLine(a1.X);                   // property
            a1.X = 12;
            Console.WriteLine(a1.X);

            // static property
            Console.WriteLine(A.Y);
            A.Y = 12;
            Console.WriteLine(A.Y);


            // static Display method
            A.Display();



            // indexer
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;
            //a[3] = 4;

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            // A a;                           // give error because a.X ko value dena padta hai
            //Console.WriteLine(a.X);

            


            Console.Read();
        }
    }
}
