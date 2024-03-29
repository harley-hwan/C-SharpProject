﻿using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;

            int lastTick = 0;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            while (true) 
            {
                #region 프레임 관리
                // FPS 프레임 (60프레임 OK, 30프레임 이하 NO) : 1초에 몇번 동작하는가

                int currentTick = System.Environment.TickCount;
                int elapsedTick = currentTick - lastTick;   // 경과한 시간

                // 만약에 경과한 시간이 1/30초보다 작다면
                if (elapsedTick < 1000/ 30)
                    continue;
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
