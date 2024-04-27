using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Ruchir");
            list.Add("Chirag");
            list.Add("Parmar");
            list.Add("Dhruv");
            list.Add("Sapna");

            list.Remove(list[0]);
            list.RemoveAt(1);
            


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            

            ArrayList list2 = new ArrayList();

            list2.Add("Ruchir");
            list2.Add(22);
            list2.Add(23.45);
            list2.Add(43);
            list2.Add(54.5999);
     

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
            
        }
    }
}
