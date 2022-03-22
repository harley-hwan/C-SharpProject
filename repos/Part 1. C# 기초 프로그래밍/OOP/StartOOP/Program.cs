﻿using System;

namespace StartOOP
{
    // 객체 (OOP Object Oriented Programming)

    // Knight 

    // 속성: hp, attack, pos
    // 기능: Move, Attack, Die

    // Ref 참조
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight(int hp)
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack(){
            Console.WriteLine("Knight Attack");
        }
    }

    // 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            //Mage mage = new Mage();   // struct 는 new를 생략가능
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            //KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();   // 객체 생성
            knight.hp = 100;
            knight.attack = 10;
            // KillKnight(knight);

            //Knight knight2 = knight;
            //knight2.hp = 0;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;

            Console.WriteLine($"mage.hp: {mage.hp}");
            Console.WriteLine($"knight.hp: {knight.hp}");
            Console.WriteLine($"knight2.hp: {knight2.hp}");
        }
    }
}
