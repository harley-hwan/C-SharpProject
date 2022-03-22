﻿using System;

namespace ex3
{
    class Program
    {
        // 팩토리얼
        static int Factorial(int n)
        {
            int ret = 1;
            for (int num = 1; num <= n; num++)
            {
                ret *= num;
            }
            return ret;
        }

        static int Factorial1(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            // 5! = 5 * 4!
            // 5! = 5 * 4 * 3 * 2 * 1
            // n! = n * (n-1) * ... * 1 (n >= 1)
            int ret = Factorial(5);
            int ret1 = Factorial1(5);

            Console.WriteLine(ret);
            Console.WriteLine(ret1);
        }
    }
}
