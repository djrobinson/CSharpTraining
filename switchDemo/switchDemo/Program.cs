using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDemo
{
    class Program
    {
        enum Movies
        {
            Casablanca,
            Godfather,
            Matrix
        }
        static void Main(string[] args)
        {
            Movies bestMovie = Movies.Godfather;

            switch (bestMovie)
            {
                case Movies.Casablanca:
                    Console.WriteLine("casa");
                    break;
                case Movies.Godfather:
                    Console.WriteLine("fada");
                    break;
                case Movies.Matrix:
                    Console.WriteLine("Matrix");
                    break;
                default:
                    Console.WriteLine("You need to make a choice");
                    break;
            }
        }
    }
}
