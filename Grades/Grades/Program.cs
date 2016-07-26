using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Testing");
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.4f);


            GradeBook book2 = book;
            book2.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade); 
        }
    }
}
