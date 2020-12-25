using System;

namespace Fibonacci.Services
{
    public class FibonacciService
    {
        public uint GetFibonacciNumber(uint n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n <= 2)
            {
                return 1;
            }

            uint a = 1;
            uint b = 1;
            for (int i = 3; i <= n; i++)
            {
                b = b + a;
                a = b - a;
            }
            return b;
        }
    }
}
