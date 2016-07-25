using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person george = new Person() { Name = "George Washington", Age = 88 };
            string key = "George";
            dict.Add(key, george);

            dict.Add("John", new Person() { Name = "John Adams", Age = 94 });

            Person secondPresident = dict["John"];
            Console.WriteLine($"SEcond president {secondPresident.Name}");
        }
    }
}
