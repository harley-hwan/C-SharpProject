﻿using System;

namespace array
{

    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int max = 0;
            foreach (int score in scores)
            {
                if (max < score) max = score;
            }
            return max;
        }

        static int GetAverageScore(int[] scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return (int)sum / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (value == scores[i]) return i;
            }
            return -1;
        }

        static void Sort(int[] scores)
        {

        }

        static void Main(string[] args)
        {
            // 베열
            //int[] scores = new int[5] { 10, 20, 30, 40, 50 } ;
            //int[] scores = new int[] { 10, 20, 30, 40, 50 } ;
            int[] scores = { 10, 30, 40, 20, 50 } ;
            
            int maxValue = GetHighestScore(scores);
            int avgValue = GetAverageScore(scores);
            int index = GetIndexOf(scores, 30);

            Console.WriteLine(maxValue);
            Console.WriteLine(avgValue);
            Console.WriteLine(index);
            Sort(scores);

            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            //for (int i = 0; i < scores.Length; i++) 
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //foreach(int score in scores)
            //{
            //    Console.WriteLine(score);
            //}
        }
    }
}
