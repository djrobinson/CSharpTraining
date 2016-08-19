using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Enter a sentence: ");
            sentence = Console.ReadLine();
            CountSpace(sentence);

        }

        static void CountSpace(string sentence)
        {
            int spaceCount = 0;
            foreach (char c in sentence)
            {
                if (Char.IsWhiteSpace(c))
                {
                    spaceCount++;
                }
            }
            Console.WriteLine(spaceCount);
        }
    }
}
