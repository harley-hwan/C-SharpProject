﻿using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            arr[0] = 1;

            // List <- 동적 배열
            List<int> list = new List<int>();
            
            for(int i =0; i< 5; i++)
                list.Add(i);

            // 삽입 삭제
            list.Insert(2, 999);
            list.Remove(3);     // 가장 낮은 인덱스에 있는 "3" 의 값을 제거
            //bool success = list.Remove(3);
            list.RemoveAt(0);   // 해당 인덱스의 값을 제거
            list.Clear();       // 전체 삭제

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            Console.WriteLine();

            foreach (int num in list) 
                Console.WriteLine(num);
        }
    }
}
