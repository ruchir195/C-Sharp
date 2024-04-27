using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_2
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Hod { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(30);
            list1.Add(40);
            list1.Add(50);
            list1.Add(60);

            list2.Add("Ruchir");
            list2.Add("Chirag");
            list2.Add("Sahil");
            list2.Add("Rohit");
            list2.Add("Anuj");
            list2.Add("Smit");


            Console.WriteLine("List-1 Item");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList-2 Item");
            foreach (var item in list2)
            {
                Console.WriteLine(item);

            }



            List<Department> list3 = new List<Department>() {
                new Department() {Id= 1, Name="MERN", Hod="Ruchir"},
                new Department() {Id= 2, Name="MEAN", Hod="Chirag"},
                new Department() {Id= 3, Name=".Net", Hod="Gagan"},
                new Department() {Id= 4, Name="Java", Hod="Harsh"},
                new Department() {Id= 5, Name="Cloud", Hod="Sahil"},
                new Department() {Id= 6, Name="MERN", Hod="Harsh"},
                new Department() {Id= 7, Name="MERN", Hod="Sahil"}
            };


            ArrayList list4 = new ArrayList();
            list4.Add(1);
            list4.Add("Ruchir");
            list4.Add(12.5);
            list4.Add(2);
            list4.Add("Parmar");
            list4.Add(23.5);



            // methosd type linq function (lamda function)

            var result = list1.Where(s => s > 10);
            // query-1-(where) in int
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            // query-1-(where) in string
            var result1 = list2.Where(s => s.Contains("a"));

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }



            // query-2-(ofType) in int
            var result2 = list4.OfType<int>();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            // query-2-(ofType) in string
            var result3 = list4.OfType<string>();
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }


            // query-3-(orderBy) in int
            var result4 = list3.OrderByDescending(s => s.Id);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Id);
            }



            // query-3-(orderBy) in String
            var result5 = list3.OrderBy(s => s.Name);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Name);
            }


            //query-4-(Group By)
            var result6 = list3.GroupBy(s => s.Name);
            foreach(var item in result6)
            {
                Console.WriteLine(item.Key);

                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.Hod);
                }
            }


            //query-5-(Select)
            var result7 = list3.Select(s => s);
            foreach (var item in result7)
            {
                Console.WriteLine(item.Id);
            }





            Console.ReadLine();
        }
    }
}
