using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace String_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String  --> immutable

            String s = "Ruchir Parmar";
            Console.WriteLine(s);

            Console.WriteLine("s.Length = " + s.Length);
            Console.WriteLine("s.ToLower() = " + s.ToLower());
            Console.WriteLine("s.ToUpper() = " + s.ToUpper());
            Console.WriteLine("s.Substring(3) = " + s.Substring(3));
            Console.WriteLine("s.Substring(3,4) = " + s.Substring(3,4));
            Console.WriteLine("s.IndexOf(\"ir\") = " + s.IndexOf("ir"));
            Console.WriteLine("s.StartsWith(\"r\") = " + s.StartsWith("r"));
            Console.WriteLine("s.EndsWith(\"ir\") = " + s.EndsWith("ir"));
            Console.WriteLine("s.Replace(\"r\", \"s\") = " + s.Replace("r", "s"));
            Console.WriteLine("s.Contains(\"ch\") = " + s.Contains("ch"));

            String concat = String.Concat("hello", " ", "world");
            Console.WriteLine(concat);

            String s2 = "Ruchir";
            String s3 = "Parmar";
            Console.WriteLine(s2.Equals(s3));




            //using String Builder create mutable string

            StringBuilder sb = new StringBuilder();

            sb.Append("Ruchir ");
            sb.Append("Parmar");
            Console.WriteLine(sb);

            sb.Insert(7, "girishbhai ");
            Console.WriteLine(sb);

            sb.Remove(7, 11);
            Console.WriteLine(sb);

            sb.Replace("Parmar", "Art");
            Console.WriteLine(sb);

            sb.Clear();
            Console.WriteLine(sb);



            // escape sequence
            Console.WriteLine("Hello \"world\"");
            Console.WriteLine("Hello 'world'");
            Console.WriteLine("\t hello world");
            Console.WriteLine("\n Hello World");
            Console.WriteLine(@"\n \\Hello \World");
            int a = 5;
            Console.WriteLine($"Hello {a}");


            //Array
            int[] arr1 = new int[3]{ 1, 2, 3 };
            Console.WriteLine("arr1[0] = " + arr1[0]);


            int[,] arr2 = new int[3, 2] { {1,2 }, { 3, 4 }, {5, 6 } };             // 3-rows 2-columns
            Console.WriteLine("arr2[2,1] = " + arr2[2,1]);


            //jagged array
            int[][] arr3 = new int[3][];

            arr3[0] = new int[2] { 1, 2 };
            arr3[1] = new int[3] { 1, 2, 3 };
            arr3[2] = new int[5] { 1, 2, 4, 5, 6 };

            Console.WriteLine(arr3[2][2]);


            char[] c = { 'a', 'b', 'c', 'd' };
            foreach (char i in s)
            {
                Console.WriteLine(i);
            }

            

            int[] arr4 = { 10, 20, 30, 40, 50 };
            foreach(int i in arr4)
            {
                Console.WriteLine(i);
            }

            Console.Read();
            


        }
    }
}
