using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of service: {emp.YearsOfService}");

            Employee emp2 = new Employee();
            emp2.YearsOfService = 53;
            emp2.Office = 202;
            Console.WriteLine($"emp years of service: {emp2.YearsOfService}");

            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };
            Console.WriteLine($"Emp3 years of service: {emp3.YearsOfService}");
        }
    }
}
