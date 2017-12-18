using System;

namespace FibonacciApp
{
    class Program
    {
        static int ClassicFibonacci (int n) => Classic.Fibonacci(n);
        static int RecursionFibonacci (int n) => Recursion.Fibonacci(n);
        static Action<int> PrintResultToScreen = (txt) => Console.WriteLine($"Result: {txt.ToString()}");

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci numbers:");
            PrintResultToScreen(ClassicFibonacci(9));
            PrintResultToScreen(RecursionFibonacci(10));

            Console.ReadKey();
        }
    }
}
