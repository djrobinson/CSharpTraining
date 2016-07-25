using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectDemo
{
    class Manager : Employee
    {
        public bool CompanyCar { get; set; }

        public Manager(string name, bool hasCar)
            :base(name)
        {
            CompanyCar = hasCar;
        }

        public override void TakeVacation()
        {
            VacationDays += 15;
        }

        public void DriveCar()
        {
            if (CompanyCar)
            {
                Console.WriteLine("Driving the car.");
            }
        }
        public override string ToString()
        {
            return $"[Manager. Name: {Name} Car: {CompanyCar}";
        }
    }
}
