using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Testing");
            GradeBook book = new GradeBook();



            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong");
            }

            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            AddGrades(book);

            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(outputFile);
            outputFile.Close();

            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Letter Grade", stats.LetterGrade);

        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.4f);
            book.AddGrade(75);
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
