using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myHorses = 0;
            do
            {
                Console.WriteLine($"myHorses = {myHorses}");
                myHorses++;
            } while (myHorses < 0);

                Console.ReadLine();
        }
    }
}
