﻿using System;

namespace multiArray
{
    class Program
    {
        class Map
        {
            int[,] tiles =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };

            public void Render()
            {
                for (int y = 0; y < tiles.GetLength(1); y++) 
                {
                    for (int x = 0; x < tiles.GetLength(0); x++) 
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();



           // int[,] map = new int[2, 3];

            //[ . . ]
            //[ . . . . . . ]
            //[ . . . ]
            //int[][] a = new int[3][];
            //a[0] = new int[3];
            //a[1] = new int[6];
            //a[2] = new int[2];

            //a[0][0] = 1;

            /*
            // 다차원 배열
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            //int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] arr = new int[,] { { 1, 2, 3 }, { 1, 2, 3 } };

            arr[0, 0] = 1;
            arr[1, 0] = 1;
            

            // 2층 [ . . . ]
            // 1층 [ . . . ]
            */
        }
    }
}
