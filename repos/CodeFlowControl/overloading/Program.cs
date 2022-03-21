﻿using System;

namespace overloading
{
    class Program
    {
        // 함수 이름의 재사용
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }

        static double Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0) 
        {
            Console.WriteLine("Add int 호출");
            return a + b + c + d + e;
        }

        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3);
            Console.WriteLine(ret);

            int ret2 = Program.Add(2, 3, 4);
            Console.WriteLine(ret2);

            float ret3 = Program.Add(2.0f, 3.0f);
            Console.WriteLine(ret3);

            double ret4 = Program.Add(1, 2, d: 2.0f);
            Console.WriteLine(ret4);
        }
    }
}
