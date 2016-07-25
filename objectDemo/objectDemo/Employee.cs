using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectDemo
{
    class Employee
    {
        public string Name { get; set; }
        protected double VacationDays;
        public virtual void TakeVacation()
        {

        }

        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }
    }
}
