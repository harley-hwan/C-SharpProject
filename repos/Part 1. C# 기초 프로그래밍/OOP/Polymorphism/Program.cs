﻿using System;

namespace Polymorphism
{
    // OOP Polymorphism (은닉성 / 상속성 / 다형성)
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    // 오버로딩(함수 이름의 재사용), 오버라이딩

    class Knight : Player
    {
        // sealed: 봉인. 더 이상 해당 함수를 재정의할 수 없다.  사용하는 경우 거의 없음.
        public sealed override void Move()
        {
            base.Move();

            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        //public override void Move()       // 재정의할 수 없음. 
        //{
        //    base.Move();
        //    {
        //        Console.WriteLine("SuperKnight 이동!");
        //    }
        //}
    }

    class Mage : Player
    {
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }

        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
            // '없음'
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();

            //EnterGame(mage);
        }
    }
}
