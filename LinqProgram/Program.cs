using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // linq quary type program
            String[] str = { "Ruchir", "Chirag", "Sahil", "Sanket", "Parthiv" };

            var LinqStr = from st in str
                          where st.Contains('a')
                          select st;

            foreach (var st in LinqStr)
            {
                Console.WriteLine(st);
            }


            var LinqStr2 = from st in str
                           where st.Length > 6
                           select st;

            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in LinqStr2)
            {
                Console.WriteLine(item);
            }



            var LinqStr3 = from st in str
                           select st;

            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in LinqStr3)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
