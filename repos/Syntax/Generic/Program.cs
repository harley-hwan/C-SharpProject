﻿using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        // class MyList<T> where T : struct    // 어떤 T라도 괜찮지만 값 형식이어야한다.
        class MyList<T> //where T : Monster
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monster
        {

        }

        static void Test<T>(T input)      // T 자리에 어떤 Type을 넣어도 잘 동작한다.
        {

        }

        static void Main(string[] args)
        {
            //var obj3 = 3;
            //var obj4 = "hello world";     // 자동으로 var를 값에 맞춤.

            // boxing
            //object obj = 3;
            //object obj2 = "hello world";

            //int nubmer = 3;

            // unboxing
            //int num = (int)obj;
            //string str = (string)obj2;

            Test<int>(3);
            Test<float>(3.0f);

            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myshortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();
        }
    }
}
