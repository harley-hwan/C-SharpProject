﻿using System;

namespace ref_out
{
    class Program
    {
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        // 덧셈 함수
        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Main(string[] args)
        {
            /////////////////////////////////////////////////// ref
            // 복사(짭퉁) 참조(진퉁)
            int a = 0;
            Program.AddOne(ref a);
            Console.WriteLine(a);

            int b = Program.AddOne2(a);
            a = b;
            //a = Program.AddOne2(a);
            Console.WriteLine(a);

            ////////////////////////////////////////////////// swap
            int num1 = 1;
            int num2 = 2;
            Program.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            /////////////////////////////////////////////////// out
            num1 = 10;
            num2 = 3;

            int result1;
            int result2;
            Divide(10, 3, out result1, out result2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
