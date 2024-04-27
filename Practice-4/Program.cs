using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



using A;
using B.C;
using PracticeNameSpace_2;
using D;

namespace Practice_4
{

    class Prac22 : Prac2
    {
        public void Prac22Show()
        {
            Console.WriteLine(" v1 = " + v1 + " v2 = "  + " v3 = " + v3 + " v4 = " );  
            // if prac2 class namesapce practiceNamespace-2 ka namesapce
            // hai to ab ham prac22 ko prac2 ke sath inherit karte hai tab protected variable and public use
            // karte hai but private and internal use nahi kar sakte hai 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // namespace A class Name1
            A.Name1 n1 = new A.Name1();
            n1.Show();


            // inner namespace C and class InnerName
            B.C.InnerName c1 = new B.C.InnerName();
            c1.InnerShow();


            // outer namespace B and Class OuterName
            B.OuterName b1 = new B.OuterName();
            b1.OuterShow();


            // practiceNamespace-2 project class A and methos Ashow()
            PracticeNameSpace_2.A a1 = new PracticeNameSpace_2.A();
            a1.Ashow();




            D.Prac d1 = new D.Prac();
            d1.v1 = 30;
            //d1.v2 = 40;                give error because v2 is private variable
            //d1.v3 = 50;                give error bacause v3 is protected variable
            //d1.v4 = 50;                give error bacause v4 is internal varibale 
            // internal access only file me access hota hai



            // namesapce D ka pract class and method pract2show method use
            D.Prac2 d2 = new D.Prac2();
            d2.Prac2Show();




            // inherit class object 
            Prac22 p2 = new Prac22();
            p2.Prac22Show();






            Console.Read();
        }
    }
}




namespace A
{
    public class Name1
    {
        public void Show()
        {
            Console.WriteLine("\n NameSpace A method Show");
        }
    }
}


namespace B
{

    public class OuterName
    {
        public void OuterShow()
        {
            Console.WriteLine("\n NameSpace OuterName class and OuterShow method");
        }
    }
    namespace C
    {
        public class InnerName
        {
          public void InnerShow()
            {
                Console.WriteLine("\n InnerNameSpace C method InnerShow()");
            }
        }
    }
}






