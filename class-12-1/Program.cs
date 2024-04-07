using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namespace program
using B;        // use namespace
using D.E;      // use innernamespace

namespace class_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();          // other namespace class object
            c1.Show();

            B.C b1 = new B.C();      // another way 
            b1.Show();

            D.E.innerNamespace innerNamespace = new D.E.innerNamespace();     // innner namspace class object
            innerNamespace.innerShow();

            D.outerNamespace outerNamespace = new D.outerNamespace();         // outer namespace class object
            outerNamespace.outerShow();

            Console.Read();
        }
    }
}


namespace B
{
    class C
    {
        public int x;

        public void Show()
        {
            Console.WriteLine("This is Show method");
        }

    }
    
}



// nested namspace
namespace D
{

    class outerNamespace
    {
        public void outerShow()
        {
            Console.WriteLine("This is outerNamespace method");
        }
    }
    namespace E
    {
        class innerNamespace
        {
           public void innerShow()
            {
                Console.WriteLine("This is namespace E class innerNamespace and innerShow method");
            }
        }
    }
}
