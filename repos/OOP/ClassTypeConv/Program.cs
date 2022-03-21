﻿using System;

namespace ClassTypeConv
{
    // 클래스 형식 변환
    // OOP (은닉성 / 상속성 / 다형성)

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            //bool isMage = (player is Mage);
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}

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

            // Mage type -> Player type 가능
            // Player type -> Mage type ?   Case by case 

            EnterGame(knight);
        }
    }
}
