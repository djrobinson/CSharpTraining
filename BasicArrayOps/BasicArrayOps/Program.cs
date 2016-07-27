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

            int x1;
            int[] x2;

            int x3 = 5;
            int[] x4 = new int[5];

            int[] x5 = new int[5] { 1, 2, 3, 5, 9 };

            foreach (int x in x5)
            {
                Console.WriteLine(x);
            }



        }
    }
}
