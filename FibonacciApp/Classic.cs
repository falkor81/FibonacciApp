using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciApp
{
    public class Classic
    {
        public static int Fibonacci(int n)
        {
            int a = 0, b = 1;
            for(int i=0; i<n; i++)
            {
                int tmp = a;
                a = b;
                b = b + tmp;
            }
            return a;
        }
    }
}
