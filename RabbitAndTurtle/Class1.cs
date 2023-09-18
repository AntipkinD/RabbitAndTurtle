using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RabbitandTurtle
{
    public class AnimalThread
    {
        internal string name;
        internal ThreadPriority priority;
        public AnimalThread(string aname, ThreadPriority apriority)
        {
            name = aname;
            priority = apriority;
        }
        public static void Run(Thread thread)
        {
            int distance = 0;
            for ( ; ; )
            {
                if (!(thread.ThreadState == ThreadState.Stopped))
                    distance++;
                else break;
            }
            Console.Write(distance + " метров");
        }
    }
    public class RabbitAndTurtle
    {
        public RabbitAndTurtle(string b, string b1, ThreadPriority c, ThreadPriority c4)
        {
            Thread first = new Thread(new ThreadStart(Console.WriteLine));
            Thread second = new Thread(new ThreadStart(Console.WriteLine));
            first.Priority = c;
            first.Start();
                Console.WriteLine($"Животное {b} с приоритетом {c} пробежало ");
            AnimalThread.Run(first);
            second.Priority = c4;
            second.Start();
                Console.WriteLine($"Животное {b1} с приоритетом {c4} пробежало ");
            AnimalThread.Run(second);
        }
    }
/*    public class RabbitAdTurtle
    {
        public RabbitAdTurtle(string b, ThreadPriority c)
        {
            Thread first = new Thread(new ThreadStart(Console.WriteLine));
            first.Priority = c;
            first.Start();
            Console.WriteLine($"Животное {b} с приоритетом {c} пробежало {AnimalThread.Run(first)} метров");

        }
    }
    public class RabbitndTurtle
    {
        public RabbitndTurtle(string b1, ThreadPriority c4)
        {
            Thread second = new Thread(new ThreadStart(Console.WriteLine));
            second.Priority = c4;
            second.Start();
            Console.WriteLine($"Животное {b1} с приоритетом {c4} пробежало {AnimalThread.Run(second)} метров");
        }
    }*/
}
