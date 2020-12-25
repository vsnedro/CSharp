using System;
using Fibonacci.Services;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibService = new FibonacciService();
            uint number = 35;
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            uint fibNumber = fibService.GetFibonacciNumber(number);
            timer.Stop();

            Console.WriteLine($"Fibonacci number of {number} is {fibNumber}");
            Console.WriteLine($"Time elapsed: {timer.Elapsed.TotalMilliseconds} ms");

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
