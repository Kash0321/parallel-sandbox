using System;
using System.Threading;

namespace Kash.Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Execution!!!");
            //Using Thread without parameter
            //CreateThreadUsingThreadClassWithoutParameter();
            //Using Thread with parameter
            CreateThreadUsingThreadClassWithParameter();
            Console.WriteLine("Finish Execution");
            Console.ReadLine();
        }

        private static void CreateThreadUsingThreadClassWithoutParameter()
        {
            var thread = new Thread(new ThreadStart(PrintNumber10Times));
            thread.Start();
        }

        private static void CreateThreadUsingThreadClassWithParameter()
        {
            var thread = new Thread(new ParameterizedThreadStart(PrintNumberNTimes));
            thread.Start(100);
        }

        private static void PrintNumber10Times()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        private static void PrintNumberNTimes(object times)
        {
            int n = Convert.ToInt32(times);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
