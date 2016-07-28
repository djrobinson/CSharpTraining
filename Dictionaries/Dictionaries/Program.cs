using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedList<string, PrimeMinister>(new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB",  new PrimeMinister("Tony Blair", 1997) }
            };

            primeMinisters.Add("GB", new PrimeMinister("John Major", 1990));

            foreach (var pm in primeMinisters.Values)
                Console.WriteLine(pm);
            

        }
    }

    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
