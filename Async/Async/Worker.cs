using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncClass.Work();
            //This async call will not move on to the next line until the task is finished
            Console.WriteLine("Back on the main thread");
        }
    }

    public class AsyncClass
    {
        public async void Work()
        {
            await SlowTask();
            Console.WriteLine("End work!");

        }

        public async Task SlowTask()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j < 10000; j++)
                {
                    var k = Math.Sqrt(j);
                }
            }
            Console.WriteLine("End of slow task");
        }
    }
}
