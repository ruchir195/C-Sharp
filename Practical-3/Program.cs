using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{

    class A
    {

        // indexer
        // indexer use for index type value like array
        // indexer is same as property but property use normal datatype int, float, string....
        // indexer ka name nahi hota                                     // property ka name hot ahi
        // indexer me parameter pass kar sakte hai                       // property me parameter pass nahi kar sakte
        private string[] names = new string[5];

        public string this[int i]              // this kyword is use
        {
            get { return names[i]; }            // same property use get and set method

            set { names[i] = value; }
        }



    }



    internal class Program
    {
        static void Main(string[] args)
        {

            // Nullable type
            Console.WriteLine("\n initialize nullable type");
            Nullable<int> x;           // nullable type declaration

            int? s = null;             // another way to declare nullable type
            Console.WriteLine("s = " + s);


            Console.WriteLine("\n HasValue method");
            if (s.HasValue)                 // HasValue method to check value is not null then enter into if conditions
            {
                Console.WriteLine("s not null value");
            }
            else                             // if value is null then enter into else condition
            {
                Console.WriteLine("s null value");
            }

            int? s1 = 23;
            Console.WriteLine("\ns1 = " + s1);
            if (s1.HasValue)
            {
                Console.WriteLine("s1 not null value");
            }
            else
            {
                Console.WriteLine("s1 null value");
            }




            // GetValueOrDefault method
            Console.WriteLine("\nGetValueOrDefault method");
            int? s4 = 20;
            int? s5 = null;
            int m3 = s4.GetValueOrDefault();
            Console.WriteLine("m3 = "+m3);
            int m4 = s5.GetValueOrDefault();
            Console.WriteLine(" m4 = "+m4);


            //Null - Coalescing Operator
            Console.WriteLine("\nNull coalescing operator");
            int? s2 = 34;
            int m = s2 ?? 24;                      // if value null nahi hogi to print 32
            Console.WriteLine("m = " + m);         // but value null then print default value means 24

            int? s3 = null;
            int m2 = s3 ?? 25;
            Console.WriteLine("m2 = " + m2);




            // Nullable.compare method
            // Nullable.compare method ka use null or normal value ko compare karne ke liye hota hai 
            Console.WriteLine("\n Nullable.compare method");
            int? a = null;                             // if null,10 then (a,b) < 0
            int? b = 10;                               // if 10,null then (a,b) > 0
                                                       // if null,null then (a,b) = 0
            if(Nullable.Compare<int>(a,b) < 0)
            {
                Console.WriteLine("(a,b) < 0");
            }
            else if(Nullable.Compare(a,b) > 0)
            {
                Console.WriteLine("(a,b) > 0");
            }
            else
            {
                Console.WriteLine("(a, b) = 0");
            }




            // indexer
            // object
            A a1 = new A();

            Console.WriteLine("\nIndexer");
            // in object pass array value means indexer
            a1[0] = "Ruchir";
            a1[1] = "Parmar";
            a1[2] = "Girshbhai";
            a1[3] = "Laxman";
            a1[4] = "Primal";


            // show the array value
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine(a1[i]);
            }



            Console.Read();
        }
    }
}
