using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            List<Person> people = new List<Person>();

            Person john = new Person() { Name = "John" };
            people.Add(john);
            people.Add(new Person() { Name = "Paul" });
            people.Add(new Person() { Name = "George" });

            foreach(Person person in people)
            {
                Console.WriteLine($"Name = {person.Name}");
            }
        }
    }
}
