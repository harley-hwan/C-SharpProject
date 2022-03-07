using System;

namespace CSharp
{
    // 객체 (OOP Object Oriented Programming)

    // Knight
    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Knight knight = new Knight();
            Knight knight = new();  // 이렇게 간략하게 선언할 수도 있음.

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
