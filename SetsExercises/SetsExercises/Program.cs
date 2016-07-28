using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York",
                "Detroit",
                "Sterling",
                "Norfolk"
            };

            string[] citiesInWorld = { "Norfolk", "Detroit", "Manchester" };

            bigCities.Add("Murica");
            bigCities.Add("Norfolk");

            //UnionWith, IntersectWith, etc
            bigCities.UnionWith(citiesInWorld);
            
            foreach (string city in bigCities)
                Console.WriteLine(city);

        }
    }
}
