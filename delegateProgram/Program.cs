using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delegateProgram
{
    // normal delegate
    delegate int std1(int x,int y);

    // delegate anonymus
    delegate int std2(int x, int y);

    class Student
    { 
        public int Add(int x, int y)
        {
            Console.WriteLine(x + ", " + y);
            return x + y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s2 = new Student();

            // delegate object and pass student class method
            std1 s3 = new std1(s2.Add);
            s3(10, 20);

            // anonyms delegate
            std2 s4 = delegate(int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(s4(20, 30));

            Console.Read();
        }
    }
}
