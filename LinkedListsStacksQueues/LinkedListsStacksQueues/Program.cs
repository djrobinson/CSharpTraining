using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsStacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //var presidents = new LinkedList<string>();

            //presidents.AddLast("JFK");
            //presidents.AddLast("LBJ");
            //presidents.AddLast("Nixon");

            //LinkedListNode<string> nixon = presidents.Find("Nixon");
            //presidents.AddAfter(nixon, "Gerald Ford");
            //presidents.RemoveFirst();
            //presidents.AddFirst("John F Kennedy");

            //foreach (string president in presidents)
            //    Console.WriteLine(president);

            //Stack<string> books = new Stack<string>();

            //books.Push("Crime and Punishment");
            //books.Push("The Idiot");
            //books.Push("Notes from the Underground");

            //Console.WriteLine("All Books: ");
            //foreach (string title in books)
            //    Console.WriteLine(title);

            //books.Pop();

            //foreach (string title in books)
            //    Console.WriteLine(title);

            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Go home");
            tasks.Enqueue("Fall asleep");
            tasks.Enqueue("Have Nightmares");

            Console.WriteLine("All Tasks:");
            foreach (string title in tasks)
                Console.WriteLine(title);

            string nextTask = tasks.Dequeue();

            foreach (string title in tasks)
                Console.WriteLine(title);
        }
    }
}
