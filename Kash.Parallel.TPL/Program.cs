﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Kash.Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nManagedThreadId (main): {Thread.CurrentThread.ManagedThreadId}");
            //var task = new Task(() => {
            //var task = Task.Factory.StartNew(() => {
            var task = Task.Run(() => {
                Console.WriteLine($"ManagedThreadId (taskr): {Thread.CurrentThread.ManagedThreadId}");
                PrintNumberNTimes(100);
            });
            
            Console.WriteLine("Inicio");
            //task.Start();
            Console.WriteLine("Fin");
            task.Wait();
        }

        private static void PrintNumberNTimes(object times)
        {
            int n = Convert.ToInt32(times);
            Task.Delay(2000);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i.ToString("00")} ");
            }
            Console.WriteLine($"\nManagedThreadId (task): {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
