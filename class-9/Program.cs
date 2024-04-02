using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_9
{

    // new and overrider keyword (override and overhide) program
    class A
    {
        public A() { }

        public virtual void Show()
        {
            Console.WriteLine("\nBase Class A method Show");
        }

    }

    class B:A
    {
        public B() { }

        public override void Show()
        {
            Console.WriteLine("\nDerive Class B method Show");
        }
    }


    class C : B
    {
        public C() { }

        public override void Show()
        {
            Console.WriteLine("\nDerive class C method Show");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            B b1 = new B();
            C c1 = new C();

            Console.WriteLine("\n object to call method");
            a1.Show();
            b1.Show();
            c1.Show();


            Console.WriteLine("\n\n\n new and override");

            A a2 = b1;
            a2.Show();
                                     // if B methos and C method is not written any keyword then show base class method
                                     // means A class method and B class method with warning

            B b2 = c1;              // if B method is new and C method new then show base class method
            b2.Show();              // means A class method and B class method  // not give warning  // overhide
                                    

                                    // if A method is virtual, B method is overirde and C method is new then
                                    // a2.show() give the derive class method means B class method because use override  and
                                    // b2.show() give the base class method means B class method because use new keyword



                                   // if A method is virtual, B method is override and C method is override then
                                   // a2.show() give the derive class method means B class method because use override and
                                   // b2.show() give the derive class method means C class method because use override.






            Console.Read();
        }
    }
}
