using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //DisplayItems(daysOfWeek);

            AllDaysOfWeek allDays = new AllDaysOfWeek();
            foreach (string day in allDays)
                Console.WriteLine(day);
        }

        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    moreItems = enumerator.MoveNext();
                }
            }
        }
    }

    public class AllDaysOfWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("calling generic getenum");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }
        //this is an old method, not necessary to implement
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
