using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayOps
{
    class Program
    {
        static void Main(string[] args)
        {
            //string monday = "Monday";
            //string[] daysOfWeek =
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};
            //string tuesday = daysOfWeek[1];
            //Console.WriteLine(tuesday);
            //foreach (string day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}

            //int x1;
            //int[] x2;

            //int x3 = 5;
            //int[] x4 = new int[5];

            //int[] x5 = new int[5] { 1, 2, 3, 5, 9 };

            //foreach (int x in x5)
            //{
            //    Console.WriteLine(x);
            //}

            var presidents = new List<string> {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };
            Console.WriteLine("Count = "+presidents.Count);
            Console.WriteLine("Capacity = "+ presidents.Capacity);
            presidents.Add("Barack Obama");
            presidents.Add("Barack Obama2");
            presidents.Add("Barack Obama3");
            //Doubles the capacity when it goes over size
            presidents.Add("Barack Obama4");
            presidents.Add("Barack Obama5");

            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);
            foreach (string president in presidents)
                Console.WriteLine(president);
            



        }
    }
}
