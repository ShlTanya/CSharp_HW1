using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HW11.Exercise2;

namespace HW11.Exercise2
{
    class ExampleExercise2
    {
        private readonly static Exercise2 exercise2 = new Exercise2();  

        public static void ShowExample()
        {
            int threadcount = 10;
            int availableWorkThreads, availableIoThreads;
            bool working = true;
            for (int i = 0; i < threadcount; ++i)
                ThreadPool.QueueUserWorkItem(new WaitCallback(Print));

            ThreadPool.GetMaxThreads(out int maxWorkThreads, out int maxIoThreads);
            while (working)
            {
                ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIoThreads);
                if (maxWorkThreads == availableWorkThreads)
                    working = false;
            }

            Console.WriteLine($"\nPress key to continue");
            Console.ReadKey();
        }

        public static void Print(object state)
        {
            exercise2.PrintSecond();
            exercise2.PrintFirst();
            exercise2.PrintThird();
            exercise2.PrintSecond();
            exercise2.PrintFirst();
            exercise2.PrintThird();
        }
    }
}
