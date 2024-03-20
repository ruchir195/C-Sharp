using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{

    enum department
    {
        me,
        cse,
        ch,
        ce,
        dep
    }

    class Student
    {

        int id;
        String name;
        int m1, m2, m3;
        public Student()
        {
            Console.WriteLine("defualt");
        }

        public Student(int id, String name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            Console.WriteLine("parameter constructor");
    
        }

        public void Show()
        {
            int tot = 0;
            int per;

            tot = m1 + m2 + m3;
            per = (tot / 3);
            Console.WriteLine("id = "+id);
            Console.WriteLine("name = "+name);
            Console.WriteLine("marks1 = "+m1);
            Console.WriteLine("marks2 = "+m2);
            Console.WriteLine("marks3 = "+m3);
            Console.WriteLine("total = " + tot + " percentage = " + per);
        }


        public void Display(params int[] args)
        {
            foreach (int i in args)
            {
                Console.WriteLine(i);
            }
        }


        public void Show1(int a2, int b2)
        {
            a2 = a2 + 2;
            b2 = b2 + 2;
            Console.WriteLine("in show method a2 = " + a2 + " b2 = " + b2);
        }

        public void Show2(ref int a3, ref int b3)
        {
            a3 = a3 + 2;
            b3 = b3 + 2;
            Console.WriteLine("In show2 method a3 = " + a3 + " b3 = " + b3);
        }

        public void Show3(out int a4, out int b4)
        {
            a4 = 10;
            b4 = 20;
            a4 = a4 + 2;
            b4 = b4 + 2;
            Console.WriteLine("In show method a4 = " + a4 + " b4= " + b4);
        }

        public void Show4(int a5, int b5)
        {
            a5 = a5 + 2;
            b5 = b5 + 2;
            Console.WriteLine("\n ");
            Console.WriteLine(a5 + " " + b5);
        }

        public void Show4(int a5, int b5, int c5)
        {
            a5 = a5 + 2;
            b5 = b5 + 2;
            c5 = c5 + 2;
            Console.WriteLine(a5 + " " + b5 + " " + c5);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[5] { 10, 20, 30, 40, 50 };

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }



            int[,] a1 = new int[2, 2] { { 2, 3 }, { 3, 4 } };

            Console.WriteLine(a1[1,1]);

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.WriteLine(a1[i,j]);
                }
            }

            Student s1 = new Student();
            Student s2 = new Student(1, "Ruchir", 20, 20, 30);
            s2.Show();

            department d1 = department.ce;
            Console.WriteLine(d1);

            int i1 = (int)department.ce;
            Console.WriteLine(i1);


            Console.WriteLine("Variable Arguments");
            s1.Display(10, 20);
            s1.Display(10, 20, 30, 40);
            s1.Display(100, 200, 300, 400, 500);


            // call by value
            Console.WriteLine("\n call by value");
            int a2 = 10;
            int b2 = 20;
            s1.Show1(a2, b2);
            Console.WriteLine("In main method a2 = " + a2 + " b2 = " + b2);

            // call by reference
            Console.WriteLine("\n call by reference");
            int a3 = 10;
            int b3 = 20;
            s1.Show2(ref a3, ref b3);
            Console.WriteLine("In main method a3 = " + a3 + " b3 = " + b3);



            // call by out
            Console.WriteLine("\n call by out");
            int a4;
            int b4;
            s1.Show3(out a4, out b4);
            Console.WriteLine("In s=main method a4 = " + a4 + " b4 = " + b4);



            // method overloading
            int a5 = 10;
            int b5 = 20;
            int c5 = 30;
            s1.Show4(a5, b5);
            s1.Show4(a5, b5, c5);


            Console.WriteLine("\nvar variable");
            var a6 = 10;
            Console.WriteLine(a6);

            a6 = 20;
            Console.WriteLine(a6);

            //a6 = "Ruchir";          // give error
            Console.WriteLine(a6);


            Console.WriteLine("\ndynamic varible");
            dynamic a7;
            a7 = 20;
            Console.WriteLine(a7);

            a7 = "Ruchir";
            Console.WriteLine(a7);



            Console.Read();
        }
    }
}
