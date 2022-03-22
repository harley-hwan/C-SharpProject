﻿using System;

namespace functionEX
{
    class Program
    {
        // 메소드 함수
        /*
            한정자 반환형식 이름(매개변수목록)
            {
            }
        */

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        // 덧셈 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddOne(ref int number)  // int값을 참조하는 것을 넘기겟다.
        {
            number = number + 1;
        }
        static void Main(string[] args)
        {
            Program.HelloWorld();
            // int result = Program.Add(4, 5);
            // int result = Add(4, 5);

            /////////////////////////////////////
            int a = 4;
            int b = 5;
            int result = Program.Add(b, a);
            Console.WriteLine(result);

            /////////////////////////////////////
            int c = 0;
            Program.AddOne(ref c);
            Console.WriteLine(c);
        }
    }
}
