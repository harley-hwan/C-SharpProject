﻿using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 구구단
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
