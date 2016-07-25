using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        public int YearsOfService { get; set; }
        public int Office { get; set; }
        public Employee(int year, int office)
        {
            YearsOfService = year;
            Office = office;
        }
        public Employee()
        {
        }
    }
}
