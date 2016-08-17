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
            int attempts = 0;
            string username = "Danny";
            string password = "password";

            do
            {
                Console.WriteLine("Username: ");
                string usernameAttempt = Console.ReadLine();
                Console.WriteLine("Password: ");
                string passwordAttempt = Console.ReadLine();

                if (username != usernameAttempt || password != passwordAttempt)
                {
                    attempts++;
                }
                else
                {
                    Console.WriteLine("You're logged in-ish");
                    attempts = 3;
                }

            } while (attempts < 3);

        }
    }
}
