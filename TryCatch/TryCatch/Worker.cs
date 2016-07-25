using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Console.WriteLine("Open file here...");
            try
            {
                Console.WriteLine("Throwing Exception...");
                throw new System.Exception();
            }
            catch
            {
                Console.WriteLine("Handling exceptions!");
            }
            finally
            {
                Console.WriteLine("Closing file...");
            }
        }
    }
}
