using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            char[] brokenValue;
            Console.WriteLine("Enter 3 letters");
            inputValue = Console.ReadLine();
            brokenValue = inputValue.ToCharArray();
            for (var i = brokenValue.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(brokenValue[i]);
            }
        }
    }
}
