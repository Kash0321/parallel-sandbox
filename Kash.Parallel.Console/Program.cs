using System.Threading;

namespace Kash.Parallel.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start Execution!!!");
            //Using Thread without parameter
            CreateThreadUsingThreadClassWithoutParameter();
            System.Console.WriteLine("Finish Execution");
            System.Console.ReadLine();
        }
        private static void CreateThreadUsingThreadClassWithoutParameter()
        {
            Thread thread;
            thread = new Thread(new ThreadStart(PrintNumber10Times));
            thread.Start();
        }
        private static void PrintNumber10Times()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
        }
    }
}
