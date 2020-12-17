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
            if (n == 1)
            {
                return 1;
            }

            uint a = 0;
            uint b = 1;
            for (int i = 2; i <= n; i++)
            {
                b = b + a;
                a = b - a;
            }
            return b;
        }
    }
}
