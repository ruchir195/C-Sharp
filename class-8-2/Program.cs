using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8_2
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

        public void Show()
        {
            Console.WriteLine("Show method in base class");
        }

         public virtual void Display()
        {
            Console.WriteLine("Display method in base class");
        }
    }


    class B:A
    {
        public int y;

        public B()
        {

        }

        public B(int x,int y):base(x)
        {
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine("Show method in derive class");
        }


        public sealed override void Display()
        {
            Console.WriteLine("Display method in base class");
        }


    }


    class D:B
    {
        public D()
        {

        }


     //  public override void Display()                           // give error cannot overriden because base class B use sealed overrider Display method
     //   {
     //       Console.WriteLine("Ruchir");
     //   }
    }

    sealed class C
    {
        public C()
        {

        }

        public void Show()
        {
            Console.WriteLine("Show method in class c");
        }
    }


    // give error
    // cannot inherit because class c is sealed
   // class D : C
    //{
   //    
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();

            A a2 = new A(10);
            B b2 = new B(20,30);

            a2.Show();
            b2.Show();


            //a2.Display();


            //A r = b2;
            //r.Display();

            D d1 = new D();
            d1.Display();

            Console.Read();
        }
    }
}
