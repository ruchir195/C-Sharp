using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_13
{

    public class A
    {
        public void Display()
        {
            Console.WriteLine("This is class A method Display");
        }
    }

    public class B : Class1
    {
        public void Show2()
        {
            Console.WriteLine("This is class B method Show2");
        }
    }




    public static class D
    {
        public static void Display2(this Class1 c2)
        {
            Console.WriteLine("\n I extended");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // class Library object and use show() method
            ClassLibrary1.Class1 c2 = new ClassLibrary1.Class1();
            c2.Show();      

            
            A a1 = new A();       // class A object and that method Display()
            a1.Display();

            B b1 = new B();      // class B object and that method show2()
            b1.Show2();



            // class library reference and class B refernce  inheritance
            Class1 c3 = new B();
            c3.Show();                  // show method in base class means class library class



            // extention object
            Class1 c4 = new Class1();
            c4.Display2();
            c4.Show();
            

            

            
            Console.Read();
        }
    }
}
