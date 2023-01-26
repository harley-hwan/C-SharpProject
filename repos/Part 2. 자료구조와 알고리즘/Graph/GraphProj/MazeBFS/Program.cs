using System;

namespace MazeBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.Initialize(25, player);
            player.Initialize(1, 1, board);

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            //const char CIRCLE = '\u25cf';
            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리
                // FPS 프레임 (60프레임 OK, 30프레임 이하 NO) : 1초에 몇번 동작하는가

                int currentTick = System.Environment.TickCount;
                int elapsedTick = currentTick - lastTick;   // 경과한 시간

                // 만약에 경과한 시간이 1/30초보다 작다면
                if (elapsedTick < WAIT_TICK)
                    continue;
                int deltaTick = currentTick - lastTick; // 경과한 시간.
                lastTick = currentTick;

                #endregion

                // 입력

                // 로직
                player.Update(deltaTick);

                // 렌더링
                Console.SetCursorPosition(0, 0);
                board.Render();
            }
        }
    }
}
