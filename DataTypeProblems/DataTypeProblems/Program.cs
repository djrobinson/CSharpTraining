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
            int firstNumber;
            int secondNumber;
            string operation;
            int answer;

            Console.WriteLine("Enter first number: ");
            firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input operation: ");
            operation = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            secondNumber = Int32.Parse(Console.ReadLine());

            if (operation == "+")
            {
                answer = firstNumber + secondNumber;
                Console.WriteLine(answer);
            }
            else if (operation == "-")
            {
                answer = firstNumber - secondNumber;
                Console.WriteLine(answer);
            }

        }
    }
}
