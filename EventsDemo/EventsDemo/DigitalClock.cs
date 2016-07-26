using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class DigitalClock
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Current time:: {e.Hour.ToString()}");
        }
    }
}
