using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputValue;
            //char[] brokenValue;
            //Console.WriteLine("Enter 3 letters");
            //inputValue = Console.ReadLine();
            //brokenValue = inputValue.ToCharArray();
            //for (var i = brokenValue.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(brokenValue[i]);
            //}

            int printNumber;
            int width;
            ArrayList numList = new ArrayList();

            Console.WriteLine("Enter a number: ");
            printNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a width: ");
            width = Int32.Parse(Console.ReadLine());
            for (var i = 0; i < width; i++)
            {
                numList.Add(printNumber);
            }
            RunProgram(numList);
        }

        public static void RunProgram(ArrayList numList)
        {
            var originalCount = numList.Count;
            for (var i = 0; i < originalCount; i++)
            {
                PrintAllVals(numList);
                numList.RemoveAt(numList.Count - 1);
            }
        }


        public static void PrintAllVals(IEnumerable currList)
        {
            foreach (int i in currList)
                Console.Write(i);
            Console.WriteLine();
        }
    }
}
