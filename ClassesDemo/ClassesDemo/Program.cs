using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tony = new Employee();
            tony.Income = 150000;
            tony.YearsOfService = 8;
            tony.Setrating(Employee.Rating.excellent);
            tony.CalulateRaise();
        }
    }

    public class Employee
    {
        public enum Rating
        {
            poor,
            good,
            excellent
        }

        private Rating rating;
        public double Income { get; set; }
        public int YearsOfService { get; set; }
        public void Setrating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalulateRaise()
        {
            double baseRaise = Income * .05;
            double bonus = YearsOfService * 1000;
            Income += baseRaise + bonus;

            switch(rating)
            {
                case Rating.poor:
                    Income -= YearsOfService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearsOfService * 2000;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Income is {Income}");
        }
    }
}
