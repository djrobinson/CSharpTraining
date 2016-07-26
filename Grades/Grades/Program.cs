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

            //book.NameChanged = new NameChangedDelegate(OnNameChanged);

            book.AddGrade(91);
            book.AddGrade(89.4f);
            book.AddGrade(75);

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Letter Grade", stats.LetterGrade);

        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0} : {1}", description, result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine("{0} : {1}", description, result);
        }
    }
}
