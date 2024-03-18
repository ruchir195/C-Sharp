using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_3
{
    internal class Program
    {
        static void Display(params int[] args)            //params keyword important for use of variable arguments
        {
            foreach(int i in args)
            {
                Console.WriteLine(i);
            }
        }


        static void Show(int i, int j)
        {
            i = i + 2;
            j = j + 2;
            Console.WriteLine("In show i =  " + i+" j= "+j);
        }



        static void Show2(ref int i2, ref int j2)
        {
            i2 = i2 + 2;
            j2 = j2 + 2;
            Console.WriteLine("in Show2 i2 = " + i2 + " j2 = " + j2);
        }



        static void Show3(out int i3, out int j3)
        {
            i3 = 10;
            j3 = 20;
            i3 = i3 + 2;
            j3 = j3 + 2;
            Console.WriteLine("In Show3 i3 = " + i3 + " j3 = " + j3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Variable Arguments");
            Display(1, 2);
            Display(1, 3, 5, 7, 9);
            Display(10, 20, 30, 40, 50, 60, 70, 80, 90);


            // call by value
            Console.WriteLine("\ncall by value");
            int i = 10;                                 // output i=12 and j = 22 in show method but
            int j = 20;                                 // output i = 10 and j = 20 in main method 

            Show(i, j);
            Console.WriteLine("in main i = " + i+" j= "+j);



            // call by reference
            Console.WriteLine("\n Call by refernces");
            int i2 = 10;                      // in call by reference, variable initialize is compulsory otherwise give an error
            int j2 = 20;                      // pass the variable. use this variable value in method as well as in main 
                                              // means output i2 = 12 and j2 = 22 same in method show2 and main
            Show2(ref i2,ref j2);
            Console.WriteLine("In main i2 = " + i2 + " j2 = " + j2);



            // call by out
            Console.WriteLine("\n Call by out");
            int i3;            // in call by out, variable initialize is not compulsory.
            int j3;           // only pass variable. initialize the varible in method and use this variable value in method as well as in main.
                              // means output i3 = 12 and j3 = 22 same in method show3 and main
            Show3(out i3, out j3);
            Console.WriteLine("In main i3 = " + i3 + " j3 = " + j3);





            // Command Line Arguments

            Console.WriteLine("\nCommand Line Arguments");
            String s = args[0];
            String s2 = args[1];

            int s3 = Convert.ToInt16(args[2]);
            int s4 = Convert.ToInt16(args[3]);

            Console.WriteLine("s = " + s);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s3 = " + s3);
            Console.WriteLine("s4 = " + s4);

            Console.Read();
        }
    }
}
