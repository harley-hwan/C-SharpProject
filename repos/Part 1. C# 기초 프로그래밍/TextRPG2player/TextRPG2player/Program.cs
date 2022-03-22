using System;

namespace TextRPG2player
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
            //while (true)
            //{
            //    Console.WriteLine("직업을 선택하세요");
            //    Console.ReadLine();
            //}

            //// _ = new Player();
            //Player player = new Knight();
            //Player player2 = new Archer();
            //Monster monster = new Orc();

            //int damage = player.GetAttack();
            //monster.OnDamaged(damage);
        }
    }
}
