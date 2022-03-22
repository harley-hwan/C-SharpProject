﻿using System;

namespace Delegate
{
    class Program
    {
        // 업체 사장 - 사장님의 비서
        // 우리의 연락처/용건
        // 거꾸로 -> 연락을 달라고

        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘어주는 그런 형식
        // 반환: int,  입력: void
        // Onclicked이 delegate 형식의 이름이다.

        // UI
        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            // 함수를 호출();
            clickedFunction();
        }

        // [ 10 20 40 30 50 ]

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate 2");
            return 0;
        }


        static void Main(string[] args)
        {
            // delegate (대리자)
            Console.WriteLine();

            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
