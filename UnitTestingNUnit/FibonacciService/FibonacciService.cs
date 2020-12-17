﻿using System;

namespace Fibonacci.Services
{
    public class FibonacciService
    {
        public int GetFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                b = b + a;
                a = b - a;
            }
            return b;
        }
    }
}
