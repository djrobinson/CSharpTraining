using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 26; //comment
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Danny Robinson";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");
            Console.ReadLine();

            myAge = 40;
            x = 20;
            myHourlyRate = 85.00;
            myName = "George";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");
            Console.ReadLine();
        }
    }
}
