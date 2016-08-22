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
            ArrayList numbers = new ArrayList();

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number {0}: ", i);
                var num = Int32.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            CalculateTotal(numbers);
            

        }

        static int CalculateTotal(ArrayList numbers)
        {
            var total = 0;
           foreach(int num in numbers)
           {
                total += num;
           }
            Console.WriteLine(total);
            return total;
        }
    }
}
