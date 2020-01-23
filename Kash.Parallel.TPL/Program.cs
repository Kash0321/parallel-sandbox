using System;
using System.Threading.Tasks;

namespace Kash.Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(() => {
                PrintNumberNTimes(100);
            });
            
            Console.WriteLine("Inicio");
            task.Start();
            Console.WriteLine("Fin");

            task.Wait();
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
