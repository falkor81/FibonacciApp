using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciApp
{
    public class Recursion
    {
        public static int Fibonacci(int n)
        {
            int result = n < 2 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
            return result;
        }
    }
}
